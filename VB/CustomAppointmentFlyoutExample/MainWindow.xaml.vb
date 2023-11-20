Imports DevExpress.Xpf.Scheduling
Imports System.Drawing
Imports System.Windows

Namespace CustomAppointmentFlyoutExample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.scheduler.AppointmentItems.Add(New AppointmentItem() With {.Start = Date.Now, .[End] = Date.Now.AddHours(2), .LabelId = 1, .StatusId = 1, .Subject = "TEST"})
            Me.scheduler.AppointmentItems.Add(New AppointmentItem() With {.Start = Date.Now.AddHours(1), .[End] = Date.Now.AddHours(3), .LabelId = 1, .StatusId = 1, .Subject = "TEST2"})
        End Sub
    End Class
End Namespace
