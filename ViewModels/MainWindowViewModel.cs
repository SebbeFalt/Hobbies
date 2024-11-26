using Hobbies.Models;
using Hobbies.MVVM;
using System.Collections.ObjectModel;

namespace Hobbies.ViewModels
{

  public class MainWindowViewModel : ViewModelBase
  {
    public ObservableCollection<Hobby> Hobbies { get; set; }
    public DelegateCommand AddCommand => new DelegateCommand(execute => AddHobby());
    public DelegateCommand RemoveCommand => new DelegateCommand(execute => RemoveHobby(), canExecute => SelectedHobby != null);

    public MainWindowViewModel()
    {
      Hobbies = new();
      Hobbies.Add(new Hobby
      {
        Name = "Frilufts",
        Description = "Sol och friskluft, vad kan gå fel?",
        IsFavorite = true
      });
      Hobbies.Add(new Hobby
      {
        Name = "TV-Spel",
        Description = "Långa vintrar ger många speltimmar.",
        IsFavorite = true
      });
      Hobbies.Add(new Hobby
      {
        Name = "Längdskidor",
        Description = "Man måste ju röra på sig lite också.",
        IsFavorite = false
      });
    }
    private Hobby selectedHobby;

    public Hobby SelectedHobby
    {
      get { return selectedHobby; }
      set
      {
        selectedHobby = value;
        OnPropertyChanged();
      }
    }
    private void AddHobby()
    {
      Hobbies.Add(new Hobby
      {
        Name = "NEW HOBBY",
        Description = "EMPTY DESCRIPTION",
        IsFavorite = false
      });
    }

    private void RemoveHobby() => Hobbies.Remove(SelectedHobby);

  }
}
