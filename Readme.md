<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655894/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T584389)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Scheduler - Customize the Appointment Flyout and Tooltip

The [DevExpress WPF Scheduler](https://docs.devexpress.com/WPF/114881/controls-and-libraries/scheduler) control can display additional information for appointments when the mouse pointer hovers over them. This information is shown in the `FlyoutControl` or `ToolTip` element. To define the displayed element, use the [ToolTipMode](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.SchedulerControl.ToolTipMode) property.

Use the [FlyoutContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.SchedulerControl.FlyoutContentTemplate) and [ToolTipContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.SchedulerControl.ToolTipContentTemplate) properties to customize the appearance of the `FlyoutControl` and `ToolTip` elements.

`ToolTipMode="Flyout"`

![image](https://user-images.githubusercontent.com/65009440/219376802-c8e7d91f-9750-4130-bbdb-d8189c89ae06.png)

`ToolTipMode="ToolTip"`

![image](https://user-images.githubusercontent.com/65009440/219376886-b52379dd-7619-474c-8437-a52cc1ee6e7e.png)

## Files to Review

* [MainWindow.xaml](./CS/CustomAppointmentFlyoutExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomAppointmentFlyoutExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomAppointmentFlyoutExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomAppointmentFlyoutExample/MainWindow.xaml.vb))

## Documentation

* [Appointment Flyout and ToolTip](https://docs.devexpress.com/WPF/119798/controls-and-libraries/scheduler/visual-elements/appointment-flyout)
* [Custom Fields](https://docs.devexpress.com/WPF/119962/controls-and-libraries/scheduler/data-binding/custom-fields)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-customize-appointment-flyout-and-tooltip&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-customize-appointment-flyout-and-tooltip&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
