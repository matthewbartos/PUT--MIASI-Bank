using System;
using System.Collections.Generic;

namespace Bank
{

    public abstract class Mediator
    {
        public abstract void transferMoney(Bank sourceBank, BankAccount sourceAccount, string destinationBankId, string destinationBankAccount, float value);
    }

    public sealed class KIR: Mediator
    {
        private List<Bank> allBank;
        private List<BankOperation> operationsInELIXIRSession;


        private static readonly Lazy<KIR> lazy =
            new Lazy<KIR>(() => new KIR());
        public static KIR Instance => lazy.Value;


        private KIR()
        {
            allBank = new List<Bank>();
            operationsInELIXIRSession = new List<BankOperation>();
        }

		public override void transferMoney(Bank sourceBank, BankAccount sourceAccount, string destinationBankId, string destinationBankAccount, float value)
		{
            sourceAccount.balance -= value;

            BankProduct destinationBankProduct = null;
            Bank destinationBank = allBank.Find((Bank obj) => obj.id == destinationBankId);
            if (destinationBank != null)
            {
                destinationBankProduct = destinationBank.bankProducts.Find((BankProduct obj) => obj.getAccountNumber() == destinationBankAccount);
            }
            if(destinationBank == null || destinationBankProduct == null) {
                CrossbankUndoTransferOperation undoTransferOperation = new CrossbankUndoTransferOperation();
                undoTransferOperation.SetBankData(sourceBank.id);
                undoTransferOperation.SetOperationData(sourceAccount, destinationBankProduct, new DateTime(), value);
                operationsInELIXIRSession.Add(undoTransferOperation);
            }


            CrossbankTransferOperation crossbankTransferOperation = new CrossbankTransferOperation();
            crossbankTransferOperation.SetBankData(sourceBank.id, destinationBank.id);
            crossbankTransferOperation.SetOperationData(sourceAccount, destinationBankProduct, new DateTime(), value);
            operationsInELIXIRSession.Add(crossbankTransferOperation);
		}

        public void performElixirSession() {
            foreach (var operation in operationsInELIXIRSession) {
                operation.Execute();
            }
            operationsInELIXIRSession.Clear();
        }

		public void registerBank(Bank bank) {
            allBank.Add(bank);
        }

    }
}