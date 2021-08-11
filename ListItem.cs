/* We'll use this code to store our activities,
by their names*/
using System;

namespace pickme
{
    public class ListItem
    {
        public ListItem(string name)
        {
            Name = name;

        }
        public string Name { get; set; }
    }
}