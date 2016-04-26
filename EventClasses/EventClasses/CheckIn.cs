using System;

namespace EventClasses
{
    public class CheckIn
    {
      ////  static DAL Start = new DAL();
      //  DBAdmin DatabaseAdmin = new DBAdmin(Start);
        public string RfidTag { get; private set; }
        public int Aanwezig { get;  set; }
        public string Naam { get; private set; }
        public Boolean Betaald { get; private set; }

        public CheckIn(string rfidTag, string naam , int aanwezig , Boolean payment)
        {
            RfidTag = rfidTag;
            Naam = naam;
            Aanwezig = aanwezig;
            Betaald = payment;
        }
        public void UpdatePayment(bool val)
        {
            Betaald = val;
        }
        }
    }
