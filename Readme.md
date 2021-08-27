<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655894/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T584389)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/CustomAppointmentFlyoutExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomAppointmentFlyoutExample/MainWindow.xaml))
<!-- default file list end -->

# How to customize the appointment flyout or tooltip

SchedulerControl can display additional information for appointments when the mouse pointer hovers over them. For this, it uses either the corresponding FlyoutControl or ToolTip elements. To define which element should be used for this purpose, use the [ToolTipMode](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.SchedulerControl.ToolTipMode) property.

To customize the appearance of this **FlyoutControl** or **ToolTip** element, define a custom DataTemplte in the [FlyoutContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.SchedulerControl.FlyoutContentTemplate) or [ToolTipContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.SchedulerControl.ToolTipContentTemplate) property respectively. This example illustrates how to do this.


<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-the-appointment-flyout-t584389/19.2.3+/media/T584389.gif">
