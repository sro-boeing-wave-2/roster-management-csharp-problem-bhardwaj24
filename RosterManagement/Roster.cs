using System;
using System.Linq;
using System.Collections.Generic;

namespace RosterManagement
{
    public class CodeSchool
    {
        Dictionary<int, List<string>> _roster;

        public CodeSchool()
        {
            _roster = new Dictionary<int, List<String>>();
        }

        /// <summary>
        /// Should be able to Add Student to a Particular Wave
        /// </summary>
        /// <param name="cadet">Refers to the name of the Cadet</param>
        /// <param name="wave">Refers to the Wave number</param>
        public void Add(string cadet, int wave)
        {
            if (_roster.ContainsKey(wave))
            {
                _roster[wave].Add(cadet);

            }
            else
            {
                var list1 = new List<string>();
                list1.Add(cadet);
                _roster.Add(wave, list1);
            }
        }

        /// <summary>
        /// Returns all the Cadets in a given wave
        /// </summary>
        /// <param name="wave">Refers to the wave number from where cadet list is to be fetched</param>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Grade(int wave)
        {
            var list = new List<string>();
            if (_roster.ContainsKey(wave))
            {
                list = _roster[wave];
                list.Sort();
                return list;
            }
            else
            {
                var emptylist = new List<string>();
                return emptylist;
            }
        }

        /// <summary>
        /// Return all the cadets in the CodeSchool
        /// </summary>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Roster()
        {
            var cadets = new List<string>();
            var list2 = new List<int>();
            foreach(KeyValuePair<int,List<string>> cadetkeyvalue in _roster)
            {
                list2.Add(cadetkeyvalue.Key);
                
            }
            list2.Sort();
            foreach (int wavenumber in list2)
            {
                var list3 = Grade(wavenumber);
                foreach(string names in list3)
                {
                    cadets.Add(names);
                }

            }

            return cadets;
        }
    }
}
