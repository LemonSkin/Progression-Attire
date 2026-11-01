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
```xml
<?xml version="1.0" encoding="utf-8" ?>
<Patch>
  <!-- ######################################### LABELS ######################################### -->

  <!-- ######################################### RESEARCH ######################################### -->

  <!-- ######################################### REBALANCES ######################################### -->
  <Operation Class="XmlExtensions.OptionalPatch">
    <modId>ferny.progressionattire</modId>
    <key>ApplyRebalances</key>
    <defaultValue>true</defaultValue>
    <caseTrue>

    </caseTrue>
  </Operation>

  <!-- ######################################### CATEGORIES ######################################### -->
  <Operation Class="XmlExtensions.OptionalPatch">
    <modId>ferny.progressionattire</modId>
    <key>ApplyCategories</key>
    <defaultValue>true</defaultValue>
    <caseTrue>

    </caseTrue>
  </Operation>
</Patch>
```
