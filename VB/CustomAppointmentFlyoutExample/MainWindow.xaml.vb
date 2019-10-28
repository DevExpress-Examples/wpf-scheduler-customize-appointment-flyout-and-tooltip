Imports DevExpress.Xpf.Scheduling
Imports System
Imports System.Drawing
Imports System.Windows

Namespace CustomAppointmentFlyoutExample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            scheduler.AppointmentItems.Add(New AppointmentItem() With {
                .Start = Date.Now,
                .End = Date.Now.AddHours(2),
                .LabelId = 1,
                .StatusId = 1,
                .Subject = "TEST"
            })
            scheduler.AppointmentItems.Add(New AppointmentItem() With {
                .Start = Date.Now.AddHours(1),
                .End = Date.Now.AddHours(3),
                .LabelId = 1,
                .StatusId = 1,
                .Subject = "TEST2"
            })
        End Sub
    End Class
End Namespace
