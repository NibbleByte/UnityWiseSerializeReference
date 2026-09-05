<img src="https://github.com/NibbleByte/UnityWiseSerializeReference/blob/master/Docs/PublishImages/Icon-160.png" width="160" align="right">

# Wise SerializeReference Drawer
SerializeReference drawer that allows you to populate the property with instance inheriting the given type.

## Why
By default \[[SerializeReference](https://docs.unity3d.com/6000.5/Documentation/ScriptReference/SerializeReference.html)\] fields display empty data with no UI to populate it, so you can't do anything with it. You need some custom property drawer like this one to draw the interface for you.

## Usage
Use `[WiseSerializeReferenceDrawer]` attribute next to \[[SerializeReference](https://docs.unity3d.com/6000.5/Documentation/ScriptReference/SerializeReference.html)\] to have a "+" button drawn next to the field.
Pressing it will ask you to select the type to be instantiated - any class that inherits or implements the target field type.
Populated fields will display the instance type name which can be clicked to be copied or pinged if possible.

```C#
[SerializeReference]
[WiseSerializeReferenceDrawer]
public MyClass SomeField;

```

If you want to customize the drawer or have this behaviour everywhere, not just the given field (per type, not per field) have a property drawer editor that inherits `WiseSerializeReferenceBasePropertyDrawer`.

If you use \[[SerializeReference](https://docs.unity3d.com/6000.5/Documentation/ScriptReference/SerializeReference.html)\] with lists and you want to avoid duplicated references to the same instance, use `WiseSerializeReferenceValidation.ClearDuplicateReferences(this)` in your `OnValidate()` function!

![WiseSerializeReferenceDrawer](https://github.com/NibbleByte/UnityWiseSerializeReference/blob/master/Docs/Screenshots/WiseSerializeReferenceShot.png)

## Installation
* Download the single file directly: [WiseSerializeReferenceDrawer](https://github.com/NibbleByte/UnityWiseSerializeReference/blob/master/Assets/DevLocker/Utils/WiseSerializeReference/WiseSerializeReferenceDrawer.cs)
* [Asset Store](???)
* [OpenUPM](???) support:
```
npm install -g openupm-cli
openupm add devlocker.utils.wiseserializereferencedrawer
```
[![openupm](???)](???)

* Github upm package - merge this to your `Packages/manifest.json`
```
{
  "dependencies": {
    "devlocker.utils.wiseserializereferencedrawer": "https://github.com/NibbleByte/UnityWiseSerializeReference.git#upm"
}
```
