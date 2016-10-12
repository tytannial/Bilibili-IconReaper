using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIconReaper.Model
{
    class span
    {
        string _id;
        string _type;
        string _title;
        string _deltime;
        string _posttime;
        string _edittime;
        string _sttime;
        string _endtime;
        int _state;
        string _icon;
        int _weight;
        string _link;

        public string Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string Deltime
        {
            get
            {
                return _deltime;
            }

            set
            {
                _deltime = value;
            }
        }

        public string Posttime
        {
            get
            {
                return _posttime;
            }

            set
            {
                _posttime = value;
            }
        }

        public string Edittime
        {
            get
            {
                return _edittime;
            }

            set
            {
                _edittime = value;
            }
        }

        public string Sttime
        {
            get
            {
                return _sttime;
            }

            set
            {
                _sttime = value;
            }
        }

        public string Endtime
        {
            get
            {
                return _endtime;
            }

            set
            {
                _endtime = value;
            }
        }

        public int State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        public string Icon
        {
            get
            {
                return _icon;
            }

            set
            {
                _icon = value;
            }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                _weight = value;
            }
        }

        public string Link
        {
            get
            {
                return _link;
            }

            set
            {
                _link = value;
            }
        }
    }
}
