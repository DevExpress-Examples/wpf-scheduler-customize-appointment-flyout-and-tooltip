using DevExpress.Xpf.Scheduling;
using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows;

namespace CustomAppointmentFlyoutExample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            scheduler.AppointmentItems.Add(new AppointmentItem() { Start = DateTime.Now, End = DateTime.Now.AddHours(2), LabelId = 1, StatusId = 1, Subject = "TEST" });
            scheduler.AppointmentItems.Add(new AppointmentItem() { Start = DateTime.Now.AddHours(1), End = DateTime.Now.AddHours(3), LabelId = 1, StatusId = 1, Subject = "TEST2" });
        }
    }
}
