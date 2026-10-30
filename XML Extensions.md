# XML Extension Dynamic Patches

## Rebalance Toggle
```xml
<Operation Class="XmlExtensions.OptionalPatch">
    <modId>ferny.progressionattire</modId>
    <key>ApplyRebalances</key>
    <defaultValue>true</defaultValue>
    <caseTrue>
        <Operation Class="SomePatchOperation">
        </Operation>
    </caseTrue>
</Operation>
```

## Category Toggle
```xml
<Operation Class="XmlExtensions.OptionalPatch">
    <modId>ferny.progressionattire</modId>
    <key>ApplyCategories</key>
    <defaultValue>true</defaultValue>
    <caseTrue>
        <Operation Class="SomePatchOperation">
        </Operation>
    </caseTrue>
</Operation>
```
