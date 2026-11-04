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
  <Operation Class="XmlExtensions.HybridPatch">
    <xpath>
      Defs/ThingDef[defName="REPLACE_ME"]
    </xpath>
    <value>
      <recipeMaker Operation="Safe">
        <researchPrerequisite Operation="AddOrReplace"></researchPrerequisite>
        <researchPrerequisites Operation="SafeRemove" />
      </recipeMaker>
    </value>
  </Operation>

  <!-- ######################################### REBALANCES ######################################### -->
  <Operation Class="XmlExtensions.OptionalPatch">
    <modId>ferny.progressionattire</modId>
    <key>ApplyRebalances</key>
    <defaultValue>true</defaultValue>
    <caseTrue>
      <Operation Class="XmlExtensions.HybridPatch">
        <xpath>Defs/ThingDef[defName="REPLACE_ME"]</xpath>
        <value>
          <!-- <costStuffCount Operation="AddOrReplace"></costStuffCount> -->
          <statBases Operation="AddOrReplace">

          </statBases>
          <!-- <equippedStatOffsets Operation="AddOrReplace">
          </equippedStatOffsets> -->
          <!-- <recipeMaker Operation="Safe">
            <skillRequirements Operation="Safe">
              <Crafting Operation="AddOrReplace"></Crafting>
            </skillRequirements>
          </recipeMaker> -->
          <!-- <apparel Operation="Safe">
            <bodyPartGroups Operation="AddOrReplace">

            </bodyPartGroups>
          </apparel> -->
        </value>
      </Operation>
    </caseTrue>
  </Operation>

  <!-- ######################################### CATEGORIES ######################################### -->
  <Operation Class="XmlExtensions.OptionalPatch">
    <modId>ferny.progressionattire</modId>
    <key>ApplyCategories</key>
    <defaultValue>true</defaultValue>
    <caseTrue>
      <Operation Class="XmlExtensions.HybridPatch">
        <xpath>Defs/ThingDef[defName="REPLACE_ME"]</xpath>
        <value>
          <thingCategories Operation="AddOrReplace" Inherit="False">

          </thingCategories>
        </value>
      </Operation>
    </caseTrue>
  </Operation>

    <!-- ######################################### END ######################################### -->
</Patch>
```

## Patching Logic
1. Assign either costuming table or vanity table as the researchPrereq
2. Programmatically perform the following:
    - Remove trade tags
    - Remove spawn tags
    - Remove crafting requirements
    - Overwrite recipeUsers to use costuming table or vanity table
    - Apply category if option is toggled
    - Do not overwrite stats - these are kind of cheat items for players who want them
