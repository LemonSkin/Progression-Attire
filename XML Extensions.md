# XML Extension Dynamic Patches

## Rebalance Toggle

```xml
<Operation Class="ferny.ProgressionAttire.PatchOperationCheckSetting">
    <settingName>applyRebalances</settingName>
    <caseTrue>
        <Operation Class="SomePatchOperation">
        </Operation>
    </caseTrue>
</Operation>
```

## Category Toggle

```xml
<Operation Class="ferny.ProgressionAttire.PatchOperationCheckSetting">
    <settingName>applyCategories</settingName>
    <caseTrue>
        <Operation Class="SomePatchOperation">
        </Operation>
    </caseTrue>
</Operation>
```

```xml
<?xml version="1.0" encoding="utf-8" ?>
<Patch>
  <!-- ######################################### LABELS ######################################## -->


  <!-- ######################################### RESEARCH ###################################### -->
  <Operation Class="ferny.ProgressionAttire.PatchOperationMerge">
    <xpath>
      Defs/ThingDef[defName="REPLACE_ME"]
    </xpath>
    <value>
      <recipeMaker>
        <researchPrerequisite Operation="AddOrReplace"></researchPrerequisite>
        <researchPrerequisites Operation="SafeRemove" />
      </recipeMaker>
    </value>
  </Operation>
  <!-- ######################################### REBALANCES #################################### -->
  <Operation Class="ferny.ProgressionAttire.PatchOperationCheckSetting">
    <settingName>applyRebalances</settingName>
    <caseTrue>
      <Operation Class="ferny.ProgressionAttire.PatchOperationMerge">
        <xpath>Defs/ThingDef[defName="REPLACE_ME"]</xpath>
        <value>
          <!-- <costStuffCount Operation="AddOrReplace"></costStuffCount> -->
          <statBases Operation="AddOrReplace">

          </statBases>
          <!-- <equippedStatOffsets Operation="AddOrReplace">
          </equippedStatOffsets> -->
          <!-- <recipeMaker>
            <skillRequirements Operation="AddOrReplace">
              <Crafting></Crafting>
            </skillRequirements>
          </recipeMaker> -->
          <!-- <apparel>
            <bodyPartGroups Operation="AddOrReplace">

            </bodyPartGroups>
          </apparel> -->
        </value>
      </Operation>
    </caseTrue>
  </Operation>
  
  <!-- ######################################### CATEGORIES #################################### -->
  <Operation Class="ferny.ProgressionAttire.PatchOperationCheckSetting">
    <settingName>applyCategories</settingName>
    <caseTrue>
      <Operation Class="ferny.ProgressionAttire.PatchOperationMerge">
        <xpath>Defs/ThingDef[defName="REPLACE_ME"]</xpath>
        <value>
          <thingCategories Operation="AddOrReplace" Inherit="False">

          </thingCategories>
        </value>
      </Operation>
    </caseTrue>
  </Operation>
  
  <!-- ######################################### END ########################################### -->
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
