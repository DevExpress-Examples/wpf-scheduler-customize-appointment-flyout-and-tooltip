using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace CustomAppointmentFlyoutExample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class Appointment {
        public int ID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Subject { get; set; }
        public int? LabelId { get; set; }
        public string Notes { get; set; }
    }
    public class ViewModel : ViewModelBase {
        public ObservableCollection<Appointment> Appointments { get; set; }
        public ViewModel() {
            Appointments = new ObservableCollection<Appointment> {
                new Appointment { ID = 1, StartDate = DateTime.Now, EndDate = DateTime.Now.AddHours(1), Subject = "Nancy Davolio", LabelId = 7, Notes = "Blood test results are required" },
                new Appointment { ID = 2, StartDate = DateTime.Now.AddHours(2), EndDate = DateTime.Now.AddHours(4), Subject = "Steven Buchanan", LabelId = 3, Notes = "Annual check-up" },
                new Appointment { ID = 3, StartDate = DateTime.Now.AddHours(5), EndDate = DateTime.Now.AddHours(8), Subject = "Mark Oliver", LabelId = 1, Notes = "First Visit" }
            };
        }
    }
}
