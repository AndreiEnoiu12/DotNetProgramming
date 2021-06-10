using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Multimedia : INotifyPropertyChanged
    {
        public enum MediaType
        {
            CD,
            DVD
        };

        private string _title;
        private string _artist;
        private string _genre;
        private MediaType _type;

        public string title { get { return _title; } }
        public string artist { get { return _artist; } }
        public string genre { get { return _genre; } }

        public string type
        { get
            {
                return _type == MediaType.CD ? "CD" : "DVD";
            }
        }

        public Multimedia(string title, string artist, string genre, string type)
        {
            _title = title;
            _artist = artist;
            _genre = genre;

            if(type == "CD")
            {
                _type = MediaType.CD;
            }
            else
            {
                _type = MediaType.DVD;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }

    public class MultiMediaList
    {
        private List<Multimedia> multiMediaList;

        public MultiMediaList()
        {
            multiMediaList = new List<Multimedia>();

            Values();
        }

        private void Values()
        {
            multiMediaList.Add(new Multimedia("Devil", "Sebastian", "Rock", "DVD"));
            multiMediaList.Add(new Multimedia("Love", "Kevin", "Pop", "CD"));
            multiMediaList.Add(new Multimedia("Anthem", "Antohny", "Classic", "CD"));
            multiMediaList.Add(new Multimedia("Smooth", "Williams", "Jazz", "CD"));
        }

        public List<Multimedia> MediaTypes()
        {
            return multiMediaList;
        }

        public void AddNewItem(Multimedia addNew)
        {
            multiMediaList.Add(addNew);
        }
    }
}
