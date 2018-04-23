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

            scheduler.AppointmentItems.Add(New AppointmentItem() With { _
                .Start = Date.Now, _
                .End = Date.Now.AddHours(2), _
                .LabelId = 1, _
                .StatusId = 1, _
                .Subject = "TEST" _
            })
        End Sub
    End Class
End Namespace
