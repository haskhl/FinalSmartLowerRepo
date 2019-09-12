using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerApplication.DAL
{
    public class AccountingDB
    {
        public static int InsertPayment(CasePayment cp)
        {
            using (var  sl= new SmartLowerEntities())
            {
                try
                {
                    if (cp == null)
                        return -1;

                    sl.CasePayments.Add(cp);
                    return sl.SaveChanges();
                }
                catch { return -1; }
            }
        }

        public static int UpdatePayment(CasePayment cp)
        {
            using (var sl = new SmartLowerEntities())
            {
                try
                {
                    if (cp == null)
                        return -1;

                    CasePayment ca = sl.CasePayments.Where(cas => cas.PaymentDetailsId == cp.PaymentDetailsId && cas.CaseID == cp.CaseID).FirstOrDefault();
                    ca.InstallmentDetails = cp.InstallmentDetails;
                    ca.PaymentDate = cp.PaymentDate;
                    
                    ca.PayerName = cp.PayerName;
                    ca.InstallmentType = cp.InstallmentType;
                    ca.InstallmentAmount = cp.InstallmentAmount;

                    return sl.SaveChanges();
                }
                catch { return -1; }
            }
        }
        public static int DeletePayment(CasePayment cp)
        {
            using (var sl = new SmartLowerEntities())
            {
                try
                {
                    if (cp == null)
                        return -1;

                    CasePayment cap = sl.CasePayments.Where(cas => cas.PaymentDetailsId == cp.PaymentDetailsId && cas.CaseID == cp.CaseID).FirstOrDefault();
                    sl.CasePayments.Remove(cp);
                    return sl.SaveChanges();
                }
                catch { return -1; }
            }
        }

        public static CasePayment GetPayment(int paymentID)
        {
            using (var sl = new SmartLowerEntities())
            {
                try
                {
                    return sl.CasePayments.Where(cp=>cp.PaymentDetailsId == paymentID).FirstOrDefault();
                }
                catch { return null; }
            }
        }

        public static List<CasePayment> GetPaymentsByCaseID(int caseId)
        {
            using (var sl = new SmartLowerEntities())
            {
                try
                {
                    return sl.CasePayments.Where(ca => ca.CaseID == caseId).ToList();
                }
                catch { return null; }
            }
        }


        public static List<CasePayment> GetAllPayments()
        {
            using (var sl = new SmartLowerEntities())
            {
                try
                {
                    return sl.CasePayments.OrderBy(a=>a.CaseID).ToList();
                }
                catch { return null; }
            }
        }
    }
}
