using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace HelloShell
{
    public class ListViewPageModel
    {
        
        public  ObservableCollection<Person> PersonsList { get; set; }

        public Person PreviousSelectedPerson { get; set; }
        private Person _selectedPerson { get; set; }
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                if (_selectedPerson != value)
                {
                    _selectedPerson = value;
                    ExpandOrCollapseSelectedItem();
                }
            }
        }

        private void ExpandOrCollapseSelectedItem()
        {
            if (PreviousSelectedPerson != null)
            {
                PersonsList.Where(t => t.Id == PreviousSelectedPerson.Id).FirstOrDefault().IsVisible =
                false;
                
            }
            
            PersonsList.Where(t => t.Id == SelectedPerson.Id).FirstOrDefault().IsVisible =
                true;
           
            PreviousSelectedPerson = SelectedPerson;
            
        }

        public ListViewPageModel()
        {
  
                PersonsList = new ObservableCollection<Person>
                {
                 new Person(){ Id = 1,  Vid = "Строительные материалы", Cod = "21-050203-10252", Name = "Балка двутавровая горячекатаная с параллельными гранями полок широкополочная из углеродистой стали обыкновенного качества ГОСТ 535-2005(ГОСТ 26020-83) Ш 30.1 H-8000мм", Ed = "шт", Count = 20, Cenov = 0, Srok = 0, Uslov ="Доставка до обьекта", Price = 1, Charak ="" },
                 new Person(){ Id = 2,  Vid = "Строительные материалы", Cod = "21-050203-10252", Name = "Балка двутавровая горячекатаная с параллельными гранями полок широкополочная из углеродистой стали обыкновенного качества ГОСТ 535-2005(ГОСТ 26020-83) Ш 30.1 H-8000мм", Ed = "шт", Count = 20, Cenov = 0, Srok = 0, Uslov ="Доставка до обьекта", Price = 1, Charak ="" },
                 new Person(){ Id = 3,   Vid = "Строительные материалы", Cod = "21-050203-10252", Name = "Балка двутавровая горячекатаная с параллельными гранями полок широкополочная из углеродистой стали обыкновенного качества ГОСТ 535-2005(ГОСТ 26020-83) Ш 30.1 H-8000мм", Ed = "шт", Count = 20, Cenov = 0, Srok = 0, Uslov ="Доставка до обьекта", Price = 1, Charak ="" }
                
                };
            
            
        }

    }

    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Id { get; set; }

      

        public string Cod { get; set; }
        public string Name { get; set; }
        public string Vid { get; set; }

        public string Ed { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int Srok { get; set; }
        public string Uslov { get; set; }
        public int Cenov { get; set; }
        public string Charak { get; set; }

     

        private bool _isVisible { get; set; }
        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {


                if (_isVisible != value)
                {
                    _isVisible = value;
                    OnPropertyChanged();
                }

            }
        }
    }
}
