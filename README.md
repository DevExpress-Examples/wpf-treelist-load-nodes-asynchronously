<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/542494294/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1118340)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Tree List - Load Nodes Asynchronously Without Locking the Application's UI

This example demonstrates how to implement the [asynchronous child nodes selector](https://docs.devexpress.com/WPF/10366/controls-and-libraries/data-grid/display-hierarchical-data/bind-to-hierarchical-data-structure?v=22.2#fetch-nodes-asynchronously). The selector allows you to fetch child nodes in a background thread to keep the [Tree List](https://docs.devexpress.com/WPF/9759/controls-and-libraries/tree-list) responsive to user actions.

![TreeListView_Async_Loading](https://user-images.githubusercontent.com/65009440/192740394-1532369c-5069-4dfb-8192-2a7743929308.gif) 

## Files to Review

- [MainWindow.xaml](./CS/AsyncChildNodesSelector/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/AsyncChildNodesSelector/MainWindow.xaml))
- [AsyncChildNodesSelector.cs](./CS/AsyncChildNodesSelector/AsyncChildNodesSelector.cs) (VB: [AsyncChildNodesSelector.vb](./VB/AsyncChildNodesSelector/AsyncChildNodesSelector.vb))
- [ViewModel.cs](./CS/AsyncChildNodesSelector/ViewModel.cs) (VB: [ViewModel.vb](./VB/AsyncChildNodesSelector/ViewModel.vb))

## Documentation

- [Fetch Nodes Asynchronously](https://docs.devexpress.com/WPF/10366/controls-and-libraries/data-grid/display-hierarchical-data/bind-to-hierarchical-data-structure?v=22.2#fetch-nodes-asynchronously)
- [IAsyncChildNodesSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.IAsyncChildNodesSelector?v=22.2)

## More Examples

- [WPF Tree List - Use the Child Nodes Selector to Create a Hierarchical Data Structure](https://github.com/DevExpress-Examples/how-to-implement-hierarchical-data-binding-via-child-nodes-selector-e3298)
- [WPF Tree List - Implement the Child Nodes Path](https://github.com/DevExpress-Examples/how-to-implement-childnodespath-t556239)
- [WPF Tree List - Use the Hierarchical Data Template to Build a Tree](https://github.com/DevExpress-Examples/how-to-build-a-tree-via-hierarchicaldatatemplate-e3410)
