using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EventClasses
{
    public class CheckIn
    {
      ////  static DAL Start = new DAL();
      //  DBAdmin DatabaseAdmin = new DBAdmin(Start);
        public int RfidTag { get; private set; }
        public int Aanwezig { get;  set; }
        public string Naam { get; private set; }
        public Boolean Betaald { get; private set; }

        public CheckIn(int rfidTag, string naam , int aanwezig , Boolean betaald)
        {
            RfidTag = rfidTag;
            Naam = naam;
            Aanwezig = aanwezig;
            Betaald = betaald;
        }


        }
    }
