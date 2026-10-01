using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gymmanager
{
    public class Membership
    {
        private Member _owner;
        private int _monthlyprice;
        private int _months;

        public Member Owner { get { return _owner; } set { _owner = value; } }
        public int MonthlyPrice { get { return _monthlyprice; } set { _monthlyprice = value; } }
        public int Months { get { return _monthlyprice; } set { _monthlyprice = value; } }

        public Membership(Member owner, int monthlyprice, int months)
        {
            _owner = Owner;
            _monthlyprice = MonthlyPrice;
            _months = Months;
        }

        public int TotalCost()
        {        
            if(Owner.isStudent)
            {
                return Convert.ToInt32(_monthlyprice * _months * 0.8);
            }
            else
            {
                return _monthlyprice * _months;
            }
        }

    }
}
