using СправочникПоVS.Core;

namespace СправочникПоVS.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        //Объявление переменных команд для перехода на формы
        public RelayCommand HomeViewCommand_0 { get; set; }
        public RelayCommand BeginWorkViewCommand_1 { get; set; }
        public RelayCommand SpaceViewCommand_2 { get; set; }
        public RelayCommand ExamplesViewCommand_3 { get; set; }
        public RelayCommand AddonsViewCommand_4 { get; set; }

        //Объявление переменных ViewModel
        public HomeViewModel_0 HomeVM_0 { get; set; }
        public BeginWorkViewModel_1 BeginWorkVM_1 { get; set; }
        public SpaceViewModel_2 SpaceVM_2 { get; set; }
        public ExamplesViewModel_3 ExamplesVM_3 { get; set; }
        public AddonsViewModel_4 AddonsVM_4 { get; set; }

        //Текущее отображение форм в опр. области
        private object _currentView; 
        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        //Команды на переходы форм
        public MainViewModel()
        {
            HomeVM_0 = new HomeViewModel_0();
            BeginWorkVM_1 = new BeginWorkViewModel_1();
            SpaceVM_2 = new SpaceViewModel_2();
            ExamplesVM_3 = new ExamplesViewModel_3();
            AddonsVM_4 = new AddonsViewModel_4();
            CurrentView = HomeVM_0;

            HomeViewCommand_0 = new RelayCommand(o => 
            {
                CurrentView = HomeVM_0;
            });

            BeginWorkViewCommand_1 = new RelayCommand(o =>
            {
                CurrentView = BeginWorkVM_1;
            });

            SpaceViewCommand_2 = new RelayCommand(o =>
            {
                CurrentView = SpaceVM_2;
            });

            ExamplesViewCommand_3 = new RelayCommand(o =>
            {
                CurrentView = ExamplesVM_3;
            });

            AddonsViewCommand_4 = new RelayCommand(o =>
            {
                CurrentView = AddonsVM_4;
            });
        }
    }
}
