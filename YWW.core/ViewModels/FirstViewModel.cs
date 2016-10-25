using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace YWW.core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private int Counter;

        private string Success = "Congratulations on completing your goal!";

        //public FirstViewModel(int GoalCounter)
        //{
        //    Counter = GoalCounter;
        //}

        public void Init(int GoalCounter)
        {
            this.Counter = GoalCounter;
        }
        //private int Counter = 1;
        private string _dietProgress;

        public string dietProgress
        {
            get
            {
                if (Counter == 0)
                {
                    _dietProgress = "@drawable/flowers0";
                    return _dietProgress;
                }
                else if (Counter == 1)
                {
                    _dietProgress = "@drawable/flowers25";
                    return _dietProgress;
                }
                else if (Counter == 2)
                {
                    _dietProgress = "@drawable/flowers50";
                    return _dietProgress;
                }
                else if (Counter == 3)
                {
                    _dietProgress = "@drawable/flowers75";
                    return _dietProgress;
                }
                else if (Counter == 4)
                {
                    _dietProgress = "@drawable/flowers100";
                    return _dietProgress;
                }
                else if (Counter == 5)
                {
                    _dietProgress = "@drawable/flowers0";
                    Counter = 0;
                    return _dietProgress;
                }
                else
                {
                    _dietProgress = "@drawable/flowers0";
                    return _dietProgress;
                }
            }
            set
            {
                SetProperty(ref _dietProgress, value);
                RaisePropertyChanged(() => dietProgress);
            }
        }

        public ICommand EnterProgress { get; private set; }

        public FirstViewModel()
        {
            EnterProgress = new MvxCommand(() =>
            {
                if (Counter != 5)
                {
                    ShowViewModel<ProgressEntryViewModel>(new { Counter });
                }
                if (Counter == 5)
                {
                    //display text to select a new goal
                }
            });
        }
        
    }
}
