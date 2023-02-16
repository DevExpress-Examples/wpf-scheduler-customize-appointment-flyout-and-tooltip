Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace CustomAppointmentFlyoutExample

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class Appointment

        Public Property ID As Integer

        Public Property StartDate As Date?

        Public Property EndDate As Date?

        Public Property Subject As String

        Public Property LabelId As Integer?

        Public Property Notes As String
    End Class

    Public Class ViewModel
        Inherits ViewModelBase

        Public Property Appointments As ObservableCollection(Of Appointment)

        Public Sub New()
            Appointments = New ObservableCollection(Of Appointment) From {New Appointment With {.ID = 1, .StartDate = Date.Now, .EndDate = Date.Now.AddHours(1), .Subject = "Nancy Davolio", .LabelId = 7, .Notes = "Blood test results are required"}, New Appointment With {.ID = 2, .StartDate = Date.Now.AddHours(2), .EndDate = Date.Now.AddHours(4), .Subject = "Steven Buchanan", .LabelId = 3, .Notes = "Annual check-up"}, New Appointment With {.ID = 3, .StartDate = Date.Now.AddHours(5), .EndDate = Date.Now.AddHours(8), .Subject = "Mark Oliver", .LabelId = 1, .Notes = "First Visit"}}
        End Sub
    End Class
End Namespace
