using DevExpress.Xpf.Scheduling;
using System;
using System.Drawing;
using System.Windows;

namespace CustomAppointmentFlyoutExample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            scheduler.AppointmentItems.Add(new AppointmentItem() { Start = DateTime.Now, End = DateTime.Now.AddHours(2), LabelId = 1, StatusId = 1, Subject = "TEST" });
        }
    }
}
