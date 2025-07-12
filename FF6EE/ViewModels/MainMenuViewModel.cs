using FF6EE.Interfaces;
using FF6EE.Utils;
using System.Reactive;
using ReactiveUI;

namespace FF6EE.ViewModels
{
    public class MainMenuViewModel: ReactiveObject
    {
        private readonly IFileDialogService _fileDialogService;
        private readonly IWindowService _windowService;
        //private SnesRom _rom;
        //private DumpList _dumpList;
        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set => this.RaiseAndSetIfChanged(ref _currentView, value);
        }

        private bool _isRomLoaded;
        public bool IsRomLoaded
        {
            get => _isRomLoaded;
            set => this.RaiseAndSetIfChanged(ref _isRomLoaded, value);
        }

        private bool _canOpenFile;
        public bool CanOpenFile
        {
            get => _canOpenFile;
            set => this.RaiseAndSetIfChanged(ref _canOpenFile, value);
        }

        public ReactiveCommand<Unit, Unit> FileOpenRomCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> FileSaveRomCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> FileExitCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> EditorsCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> MonsterEditorCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> SettingsExpansionsCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> SettingsEditorCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> HelpAboutCommand { get; private set; }

        public MainMenuViewModel()
        {
            InitViewModel();
        }
        public MainMenuViewModel(IFileDialogService fileDialogService, IWindowService windowService)
        {
            _fileDialogService = fileDialogService;
            _windowService = windowService;
            InitViewModel();
        }

        private void InitViewModel()
        {
            CanOpenFile = true;
            //GetDumps();

            FileOpenRomCommand = ReactiveCommand.Create(FileOpenRom);
            FileSaveRomCommand = ReactiveCommand.Create(FileSaveRom);
            FileExitCommand = ReactiveCommand.Create(FileExit);
            /*MonsterEditorCommand = new RelayCommand(MonsterEditor);
            SettingsExpansionsCommand = new RelayCommand(SettingsExpansions);
            SettingsEditorCommand = new RelayCommand(SettingsEditor);
            HelpAboutCommand = new RelayCommand(HelpAbout);*/

            IsRomLoaded = false;

            // temporary
            //FileOpenRom();
        }

        private void GetDumps()
        {
            try
            {
                //_dumpList = new DumpList();
            }
            catch (ProgramException e)
            {
                var programException = new ProgramException(e);
                //var result = _windowService.ShowDialog<ErrorDialogViewModel>(_windowService, programException);
                CanOpenFile = false;
            }
        }

        private void FileOpenRom()
        {
            //TODO: change
            //string filePath = _fileDialogService.OpenFileDialog("ROM files (*.smc,*.sfc)|*.smc;*.sfc");
            //string filePath = "C:\\Users\\User\\FF6EE\\FF6EE\\bin\\Debug\\net8.0-windows\\test.smc";
            string filePath = string.Empty;
            if (filePath != null)
            {
                try
                {
                    //_rom = new SnesRom(filePath);
                    IsRomLoaded = true;
                }
                catch (ProgramException e)
                {
                    var programException = new ProgramException(e);
                    //var result = _windowService.ShowDialog<ErrorDialogViewModel>(_windowService, programException);
                }

            }

            /*if (!_rom.ValidateGameCode())
            {
                MessageBoxHelper.ShowWarning($"Game code is not a valid FFVI one. (Game code: {_rom.Header["game_code"].ValueToString()})");
            }
            else if (_rom.VerifyDump(_dumpList))
            {
                try
                {
                    _rom.LoadBuiltInDefinition();
                    CurrentView = new LoadingViewModel(_rom);
                }
                catch (ProgramException e)
                {
                    var programException = new ProgramException(e);
                    programException.Log();
                    var result = _windowService.ShowDialog<ErrorDialogViewModel>(_windowService, programException);
                }

                
            }*/
                 
        }

        private void FileSaveRom()
        {

        }

        private void FileExit()
        {

        }

        private void MonsterEditor()
        {
            /*if(CurrentView is not MonsterEditorViewModel)
            {
                CurrentView = new MonsterEditorViewModel();
            }*/
        }

        private void SettingsExpansions()
        {
            /*if (CurrentView is not SettingsExpansionsViewModel)
            {
                CurrentView = new SettingsExpansionsViewModel();
            }*/
        }

        private void SettingsEditor()
        {
            /*if (CurrentView is not SettingsEditorViewModel)
            {
                CurrentView = new SettingsEditorViewModel();
            }*/
        }

        private void HelpAbout()
        {
            /*if (CurrentView is not HelpAboutViewModel)
            {
                CurrentView = new HelpAboutViewModel();
            }*/
        }
    }
}
