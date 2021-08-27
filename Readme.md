<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616574/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1441)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyPopupControlContainer.cs](./CS/Q205284/MyPopupControlContainer.cs) (VB: [MyPopupControlContainer.vb](./VB/Q205284/MyPopupControlContainer.vb))
<!-- default file list end -->
# How to create PopupControlContainer that uses its own LookAndFeel settings


<p>To accomplish this task, you need to override the CreateSubControl method, to temporarily save the LookAndFeel assigned to this control in the designer, and then restore this LookAndFeel within the CreatePopupContainerBarControl method.</p>

<br/>


