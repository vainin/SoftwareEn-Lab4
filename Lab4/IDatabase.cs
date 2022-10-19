using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lab3
{
    public interface IDatabase
    {
        void AddEntry(Entry entry);
        bool DeleteEntry(Entry entry);
        Entry FindEntry(int id);
        ObservableCollection<Entry> GetEntries();
        ObservableCollection<Entry> SortByClue();
        ObservableCollection<Entry> SortByAnswer();
        bool EditEntry(Entry replacementEntry);
    }
}