using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T263441 {
    public class Customer {
        string _firstName;
        string _lastName;
        string _country;
        bool _hasChildren;
        int _cash;

        public Customer() {
        }

        public string FirstName {
            get { return _firstName; }
            set {
                if(value != _firstName) {
                    _firstName = value;
                }
            }
        }
        public string LastName {
            get { return _lastName; }
            set {
                if(value != _lastName) {
                    _lastName = value;
                }
            }
        }

        public string Country {
            get { return _country; }
            set {
                if(value != _country) {
                    _country = value;
                }
            }
        }

        public bool HasChildren {
            get { return _hasChildren; }
            set {
                if(value != _hasChildren) {
                    _hasChildren = value;
                }
            }
        }

        public int Cash {
            get { return _cash; }
            set {
                if(value != _cash) {
                    _cash = value;
                }
            }
        }
    }
}
