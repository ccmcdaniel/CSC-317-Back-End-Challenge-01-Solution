using System.Collections.ObjectModel;

namespace CSC_317_Back_End_Challenge_01_Solution.Pages;
public class Note
{
	public string Value { get; set; }
}

public partial class NotesPage : ContentPage
{
	public ObservableCollection<Note> Notes { get; set; }
	public NotesPage()
	{
		InitializeComponent();
		Notes = new ObservableCollection<Note>();
		Notes.Add(new Note { Value = "Example Note 1" });
		Notes.Add(new Note { Value = "Example Note 2" });
		Notes.Add(new Note { Value = "Example Note 3" });

		lstNotes.ItemsSource = Notes;
	}
}