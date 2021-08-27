<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128612418/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T236002)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/SpellCheckerMenuExample/Form1.cs) (VB: [Form1.vb](./VB/SpellCheckerMenuExample/Form1.vb))
<!-- default file list end -->
# How to display SpellChecker context menu for standard text controls (TextBox and RichTextBox)


This example demonstrates how to show the WinForms SpellChecker context menu for standard .NET <strong>TextBox</strong> and <strong>RichTextBox</strong> controls.<br />The <a href="http://help.devexpress.com/#WindowsForms/clsDevExpressXtraBarsBarManagertopic">BarManager</a> component is used to create and show the popup menu. For this, the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraBarsBarManager_QueryShowPopupMenutopic">BarManager.QueryShowPopupMenu</a> event is handled.  Menu items are obtained with the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpellCheckerSpellCheckerBase_GetCommandsByErrortopic">SpellChecker.GetCommandsByError</a> method and added to the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraBarsPopupMenuBase_ItemLinkstopic">ItemLinks</a> collection of the newly created popup menu. The <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraBarsBarManager_SetPopupContextMenutopic">BarManager.SetPopupContextMenu</a> method assigns the popup menu to the specified TextBox and RichTextBox controls.<br />Note that the DevExpress <a href="http://help.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsMemoEdittopic">MemoEdit</a> control located on the same form has a built-in SpellChecker support and does not require extra code to show the SpellChecker context menu.<br />The <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpellCheckerSpellCheckerBase_PrepareSuggestionstopic">SpellChecker.PrepareSuggestions</a> event is handled to modify suggested words displayed in the SpellChecker context menu. <br /><br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-display-spellchecker-context-menu-for-standard-text-controls-textbox-and-richtextbox-t236002/14.2.3+/media/c311b9c8-ee5a-11e4-80bf-00155d62480c.png"><br /><br />

<br/>


