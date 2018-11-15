<!-- default file list -->
*Files to look at*:

* [MyPopupControlContainer.cs](./CS/Q205284/MyPopupControlContainer.cs) (VB: [MyPopupControlContainer.vb](./VB/Q205284/MyPopupControlContainer.vb))
<!-- default file list end -->
# How to create PopupControlContainer that uses its own LookAndFeel settings


<p>To accomplish this task, you need to override the CreateSubControl method, to temporarily save the LookAndFeel assigned to this control in the designer, and then restore this LookAndFeel within the CreatePopupContainerBarControl method.</p>

<br/>


