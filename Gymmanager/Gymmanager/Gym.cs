using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymmanager
{
    public class Gym
    {
        private string _name;
        private List<Membership> _membership;
        public string Name { get { return _name; } set { _name = value; } }
        public List<Membership> Memberships { get { return _membership; } set { _membership = value; } }

        public Gym (string name)
        {
            _name = name;
            _membership = new List<Membership>();
        }

        public void AddMembership(Membership membership)
        {
            _membership.Add(membership);
        }

    }
}
