using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Pattern_Sample_Project.Services
{
    public class CollectionsManagerService
    {

        public ObservableCollection<string> AddDelimitedValuesToCollection(string delimitedValues, char delimiter,ObservableCollection<string> Collection)
        {

            var splittedCollection = delimitedValues.Split(delimiter);

            foreach (var item in splittedCollection)
            {
                if (!Collection.Contains(item) && !string.IsNullOrEmpty(item))
                {
                    Collection.Add(item);
                }
                else
                {
                    MessageBox.Show("Item is already in the list");
                }

            }

            return Collection;
        }


        public ObservableCollection<string> RemoveFromCollection(int workingListBoxIndex,
            ObservableCollection<string> Collection)
        {

            Collection.RemoveAt(workingListBoxIndex);

            return Collection;
        }

    }
}
