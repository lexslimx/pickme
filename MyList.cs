using System;
using System.Collections.Generic;

namespace pickme
{
    public class MyList
    {
        private List<ListItem> ListItems { get; set; }
        private HashSet<int> pickedMovies {get;set;}
        private Random random;
        public MyList(string listName)
        {
            ListItems = new List<ListItem>();
            random = new Random();
            pickedMovies = new HashSet<int>();
        }
        public string Name { get; set; }

        public void AddItem(string name)
        {
            ListItem listItem = new ListItem(name);
            ListItems.Add(listItem);
        }
        public ListItem Pick()
        {
            int numberOfItems = ListItems.Count;
            if (numberOfItems == 0) return null;
            int result = random.Next(0, numberOfItems);

            while(pickedMovies.Contains(result)){
               result = random.Next(0, numberOfItems);               
            } 
            pickedMovies.Add(result);
            return ListItems[result];
        }

    }
}