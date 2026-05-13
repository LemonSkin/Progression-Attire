# Rebalance
- Move the decision-making from resources to playstyle.
    - Samurai Faction armours provide 1 tier less armour but include melee buffs and dodge buffs
    - Vanilla Factions Expanded - Medieval 2 leather armours provide 1 tier less armour but include melee buffs and pain shock threshold buffs
    - Unwind the Medieval Overhaul layering system - layering should be reflective of vanilla so "larger" armours should cover middle and shell layers
    - Adorned armours should only be a little more expensive, provide similar armour values and cold buffs - maybe also a small social impact buff

# Armour Tiers
Tier 1 - Gloves + Boots
- Middle
    - Vest + Padded Chausses + Light Lamellar (Outer layer)
- Middle + Shell
    - Padded Armour

Tier 2 - Splinted Gloves + Splinted Boots
- Middle
	- Hauberk + Splinted Chausses
- Middle + Outer
	- Heavy Hauberk
    - Leather Armour - 3.5 MeleeHitChance, 0.05 PainShockThreshold, helmet provides 0.05 PainShockThreshold
    - Ashigaru Armour - 3.5 MeleeHitChance, 3.5 MeleeDodgeChance, helmet provides -0.05 MentalBreakThreshold

Tier 3 - Plate Gloves + Plate Boots
- Middle
	- Brigandine/Breast Plate/Light Plate Armor + Plate Chausses
	- Zweihander's Cuirass + Plate Chausses
- Middle + Outer
	- Plate Armor - Normal quality, steel = 81 sharp, 40.5 blunt, 54 heat
	- Full Plate
	- Heavy Plate Armor
    - Samurai - 7 MeleeHitChance, 7 MeleeDodgeChance, helmet provides -0.10 MentalBreakThreshold
    - Daimyo Armour - 7 MeleeHitChance, 7 MeleeDodgeChance, helmet provides -0.10 MentalBreakThreshold, 0.10 SocialImpact
    - Heavy Leather Armour - 7 MeleeHitChance, 0.075 PainShockThreshold, helmet provides 0.075 PainShockThreshold


Material Multipliers
| Material | Sharp | Blunt | Heat |
|----------|-------|-------|------|
| Fabric | 0.36 | 0 | 0.18 |
| Leathery | 0.75 | 0.24 | 1.5 |
| Metallic | 0.9 | 0.45 | 0.6 |

# Tier 0 Balance (Original → Proposed)
| Item | Layer | Mult | Work | Mass | Delay | Speed | Crafting | Stuff | Coverage |
|------|-------|------|------|------|-------|-------|----------|-------|----------|
| Light Padded Armour | OnSkin + Middle | 0.65 → **0.50** | 1,800 → **4,000** | 5.0 → **3.0** | 1.5 → **2.0** | — → — | — → **3** | 100 Fabric → **80** Fabric | Full body → Full body |

**Sharp with fabric:** Light Padded Armour 18.0%

## Roles

### Peasant Levy - Light Padded Armour
Thick quilted garment worn as a base layer. Full-body fabric protection that blocks the OnSkin and Middle layers, leaving only Shell free.
| Stat | Value |
| ---  | ---   |
| Full Body Sharp (Fabric) | 18.0% |
| Total Mass | 3.0 |
| Total Speed | 0 |
| Outer Slot | Free (OnSkin + Middle) |
| Work | 4,000 (1 item) |
| Crafting Req | 3 |
| Stuff Cost | 80 (Fabric)

# Tier 1 Balance (Original → Proposed)

| Item | Layer | Mult | Work | Mass | Delay | Speed | Crafting | Stuff | Coverage |
|------|-------|------|------|------|-------|-------|----------|-------|----------|
| Vest | Middle → Middle | 0.30 → 0.30 | 5,000 → **3,000** | 1.0 → 1.0 | 1.5 → 1.5 | — → — | 3 → 3 | 40 → 40 | Neck, Torso, Shoulders → Neck, Torso, Shoulders |
| Padded Chausses | Middle → Middle | 0.30 → 0.30 | 8,000 → **2,000** | 4.0 → **1.5** | 3.0 → **1.5** | — → — | 4 → **3** | 70 → **40** | Legs → Legs |
| Light Lamellar | Shell → Shell | 0.52 → **0.30** | 12,000 → **6,000** | 4.0 → **2.0** | 10 → **2.5** | — → — | 4 → 4 | 75 → **50** | Neck, Torso, Shoulders → Neck, Torso, Shoulders |
| Padded Armour | Shell → **Middle + Shell** | 0.52 → **0.40** | 12,000 → **8,000** | 4.0 → 4.0 | 10 → **3.5** | — → — | 4 → 4 | 75 → **100** | Neck, Torso, Shoulders → Neck, Torso, Shoulders, **Legs** |

**Sharp with fabric:** Vest 7.2% | Padded Chausses 7.2%
**Sharp with leathery:** Vest 22.5% | Padded Chausses 22.5% | Light Lamellar 22.5% | Padded Armour 30.0%

## Roles

### Scout - Vest + Padded Chausses
Cheap, light and modular. Shell slot remains free for a gambeson, surcoat or cloak.
| Stat | Value |
| ---  | ---   |
| Torso/Neck/Shoulders (Middle) | 22.5% |
| Legs (Middle) | 22.5% |
| Total Mass | 2.5 |
| Total Speed | 0 |
| Outer Slot | Free |
| Work | 5,000 (2 items) |
| Crafting Req | 3 |
| Stuff Cost | 80 (Leathery/Fabric)

### Outrider - Vest + Padded Chausses + Light Lamellar
Adds a Shell-layer vest for redundant torso protection at the cost of blocking the Shell slot.
| Stat | Value |
| ---  | ---   |
| Torso/Neck/Shoulders (Middle) | 22.5% |
| Torso/Neck/Shoulders (Shell) | 22.5% |
| Legs (Middle) | 22.5% |
| Total Mass | 4.5 |
| Total Speed | 0 |
| Outer Slot | Blocked |
| Work | 11,000 (3 items) |
| Crafting Req | 4 |
| Stuff Cost | 130 (Leathery/Fabric)

### Town Militia - Padded Armour
All-in-one protection with higher multiplier and leg coverage. Single item, no micro.
| Stat | Value |
| ---  | ---   |
| Torso/Neck/Shoulders/Legs (Middle + Shell) | 30.0% |
| Total Mass | 4.0 |
| Total Speed | 0 |
| Outer Slot | Blocked |
| Work | 8,000 (1 item) |
| Crafting Req | 4 |
| Stuff Cost | 100 (Leathery)


# Tier 2 Balance (Original → Proposed)

| Item | Layer | Mult | Work | Mass | Delay | Speed | Crafting | Stuff | Coverage |
|------|-------|------|------|------|-------|-------|----------|-------|----------|
| Hauberk | Middle → Middle | 0.55 → **0.50** | 27,000 → **10,000** | 6.0 → **2.0** | 10 → **4** | **-0.4 → -0.1** | 6 → **5** | 80 → **55** | Torso, Neck, Shoulders, Arms → Neck, Torso, Shoulders, Arms |
| Heavy Hauberk | Shell → **Middle + Shell** | 0.60 → **0.55** | 28,000 → **15,000** | 8.0 → **6.0** | 15 → **6** | **-0.8 → -0.2** | 6 → **7** | 100 → **100** | Full body → Full body |
| Splinted Gloves | Middle → Middle | 0.378 → **0.30** | 4,000 → 4,000 | 0.5 → **1.0** | 2.5 → **2** | -0.05 WS → -0.05 WS | 7 → **5** | 25 → **20** | Hands → Hands |
| Splinted Boots | Middle → Middle | 0.378 → **0.30** | 4,000 → 4,000 | 0.5 → **1.5** | 2.5 → **2** | -0.05 → -0.05 | 8 → **6** | 35 → **25** | Feet → Feet |
| Splinted Chausses | Middle → Middle | 0.378 → **0.30** | 19,000 → **6,000** | 9.0 → **2.0** | 3 → **2.5** | — → **-0.05** | 6 → **5** | 70 → **40** | Legs → Legs |
| Ashigaru Armor | Middle + Shell | 0.45 → **0.40** | 22,000 → **12,000** | 8 → **5** | 10 → **6** | **-0.2 → 0** | 6 → **5** | 140 → **70** | Full body → Full body |
| Leather Armor | Middle + Shell | 0.40 → **0.40** | 22,000 → **12,000** | 8 → **5** | 10 → **6** | — → **0** | 6 → **5** | 140 → **80** | Full body → Full body |
| Adorned Mail Shirt | Shell → **Middle + Shell** | 0.65 → **0.55** | 30,000 → **18,000** | 12 → **8** | 15 → **6** | **-0.8 → -0.2** | 8 → **7** | 100 + 70 Linen → **100 + 50 Linen** | Full body → Full body |

**Sharp with steel:** Hauberk 45.0% | Heavy Hauberk 49.5% | Splinted Gloves/Boots/Chausses 27.0% | Ashigaru 36.0% (steel) / 30.0% (leather) | Adorned Mail Shirt 49.5%
**Sharp with leather:** Leather Armor 30.0%
## Roles
### Skirmisher - Hauberk + Splinted Chausses
Light, fast, can wear a cloak/tabard on shell layer for insulation or social. Legs are weak - good for archers, billmen and flankers.
| Stat | Value |
| ---  | ---   |
| Torso/Arms Sharp | 45.0% |
| Legs sharp | 27.0% |
| Total Mass | 4.0 |
| Total Speed | -0.15 |
| Outer Slot | Free |
| Work | 16000 (two items ) |
| Crafting Req | 5 |
| Stuff Cost | 95 (Metallic)

### Brawler - Heavy Hauberk
Full coverage with no weak points. Heavier and slower, lose the ability to wear cloak.
| Stat | Value |
| ---  | ---   |
| Full Body Sharp | 49.5% |
| Total Mass | 6.0 |
| Total Speed | -0.2 |
| Outer Slot | Blocked |
| Work | 15000 (one item) |
| Crafting Req | 7 |
| Stuff Cost | 100 (Metallic)

### Ashigaru — Ashigaru Armor
Fast, evasive full-body armour for lightly armoured troops. Sacrifices raw protection for mobility.
| Stat | Value |
| ---  | ---   |
| Full Body Sharp (Steel) | 36.0% |
| Full Body Sharp (Leather) | 30.0% |
| Total Mass | 5.0 |
| Total Speed | 0 |
| Outer Slot | Blocked |
| Work | 12,000 (1 item) |
| Crafting Req | 5 |
| Stuff Cost | 70 (Leathery/Metallic) |
| Buffs | +1.5 MeleeDodgeChance, +3.5 MeleeHitChance

### Berserker — Leather Armor
Aggressive full-body leather armour. Minimal protection but zero speed penalty. Pairs with the Leather Helmet for maximum melee hit chance.
| Stat | Value |
| ---  | ---   |
| Full Body Sharp (Leather) | 30.0% |
| Total Mass | 5.0 |
| Total Speed | 0 |
| Outer Slot | Blocked |
| Work | 12,000 (1 item) |
| Crafting Req | 5 |
| Stuff Cost | 80 (Leathery) |
| Buffs | +2.0 MeleeHitChance, +0.05 PainShockThreshold

### Oathbound Initiate — Adorned Mail Shirt
Cold-weather variant of the Heavy Hauberk with excellent insulation. Same protection but trades some material efficiency for warmth and a minor social presence.
| Stat | Value |
| ---  | ---   |
| Full Body Sharp | 49.5% |
| Total Mass | 8.0 |
| Total Speed | -0.2 |
| Outer Slot | Blocked |
| Work | 18,000 (1 item) |
| Crafting Req | 7 |
| Stuff Cost | 100 (Metallic) + 50 Linen |
| Buffs | +0.05 SocialImpact, +15 Cold Insulation (via linen padding)

# Tier 3 Balance (Original → Proposed)

| Item | Layer | Mult | Work | Mass | Delay | Speed | Crafting | Stuff | Coverage |
|------|-------|------|------|------|-------|-------|----------|-------|----------|
| Brigandine | Shell → **Middle** | 0.65 → **0.60** | 32,000 → **15,000** | 15 → **8.0** | 15 → **6** | **-0.6 → -0.25** | 7 → **9** | 100 → **85** | Full body → Neck, Torso, Shoulders, Arms |
| Breast Plate | Shell → **Middle** | 0.73 → **0.70** | 28,000 → **18,000** | 8.0 → **6.0** | 5 → 5 | **-0.4 → -0.25** | 9 → **10** | 120 → **75** | Neck, Torso, Shoulders → Neck, Torso, Shoulders |
| Zweihander Cuirass | Shell → **Middle** | 0.73 → **0.70** | 32,000 → **20,000** | 8.0 → **6.0** | 5 → 5 | **-0.4 → -0.25** | 9 → **10** | 120 → **75** (+20 Linen) | Neck, Torso, Shoulders → Neck, Torso, Shoulders |
| Full Plate | Shell → **Middle + Shell** | 0.73 → **0.90** | 38,000 → 38,000 | 15 → 15 | 15 → 15 | -0.8 → -0.8 | 10 → **12** | 150 → **170** | Full body → Full body |
| Plate Gloves | Middle → Middle | 0.438 → **0.45** | 6,000 → 6,000 | 1.0 → **2.0** | 2.5 → 2.5 | -0.1 WS → -0.1 WS | 7 → **8** | 35 → **30** | Hands → Hands |
| Plate Boots | Middle → Middle | 0.438 → **0.45** | 6,000 → 6,000 | 1.0 → **2.5** | 2.5 → 2.5 | -0.1 → -0.1 | 10 → **8** | 45 → **35** | Feet → Feet |
| Plate Chausses | Middle → Middle | 0.458 → **0.45** | 35,000 → **8,000** | 6.0 → **3.0** | 3 → 3 | — → **-0.1** | 10 → **9** | 80 → **45** | Legs → Legs |
| Samurai Armor | Middle + Shell | 0.56 → **0.50** | 22,000 → **22,000** | 10 → **6** | 15 → **10** | **-0.4 → -0.1** | 8 → **8** | 180 → **100** | Full body → Full body |
| Daimyo Armor | Middle + Shell | 0.56 → **0.50** | 29,200 → **24,000** | 10 → **6** | 15 → **10** | **-0.4 → -0.1** | 10 → **9** | 180 → **100** | Full body → Full body |
| Heavy Leather Armor | Middle + Shell | 0.54 → **0.55** | 22,000 → **15,000** | 14 → **8** | 15 → **10** | **-0.2 → -0.1** | 8 → **8** | 180 → **100** | Full body → Full body |
| Adorned Warrior Armor | Shell → **Middle + Shell** | 0.60 → **0.70** | 38,000 → **32,000** | 15 → **10** | 15 → **10** | **-0.8 → -0.5** | 8 → **10** | 120 + 70 Linen → **120 + 50 Linen** | Full body → Full body |
| Adorned Heavy Plate | Shell → **Middle + Shell** | 0.75 → **0.90** | 45,000 → **42,000** | 17 → **10** | 20 → **15** | **-1.2 → -0.8** | 12 → **12** | 200 + 5 Gold + 70 Linen → **170 + 5 Gold + 50 Linen** | Full body → Full body |
| Gilded Full Plate | Shell → **Middle + Shell** | 0.73 → **0.90** | 50,000 → **45,000** | 17 → **15** | 20 → **15** | -0.8 → -0.8 | 16 → **13** | 150 + 5 Gold → **170 + 10 Gold** | Full body → Full body |
| Heavy Plate Armor | Middle + Shell | 1.02 → **0.95** | 60,000 → **50,000** | 20 → **18** | 20 → **15** | **-1.2 → -1.0** | 9 → **13** | 240 → **200** Metallic | Full body → Full body |

**Sharp with steel:** Brigandine 54.0% | Breast Plate 63.0% | Zweihander 63.0% | Adorned Warrior 63.0% | **Full Plate 81.0%** | Adorned Heavy Plate 81.0% | Gilded Full Plate 81.0% | Heavy Plate Armor 85.5% | Plate Gloves/Boots/Chausses 40.5% | Samurai/Daimyo 45.0% (steel) / 37.5% (leather)
**Sharp with leather:** Heavy Leather 41.25%

## Roles
### Generalist - Brigandine + Plate Chausses
Arms are protected, vitals decent, legs covered and can wear a cloak.
| Stat | Value |
| ---  | ---   |
| Torso/Neck/Shoulders/Arms Sharp | 54.0% |
| Legs Sharp | 40.5% |
| Total Mass | 11.0 |
| Total Speed | -0.35 |
| Outer Slot | Free |
| Work | 23000 (two items) |
| Crafting Req | 9 |
| Stuff Cost | 130 (Metallic)

### Vital Specialist - Breast Plate + Plate Chausses
Maximum torso protection in Tier 3 at the cost of completely exposed arms. Ideal for pawns who should not be surrounded.
| Stat | Value |
| ---  | ---   |
| Torso/Neck/Shoulders (Middle) | 63.0% |
| Legs (Middle) | 40.5% |
| Total Mass | 9.0 |
| Total Speed | -0.35 |
| Outer Slot | Free |
| Work | 26,000 (2 items) |
| Crafting Req | 10 |
| Stuff Cost | 120 (Metallic)

### Aristocrat - Zweihander Cuirass + Plate Chausses
Functionally identical protection and speed to the Breast Plate but with a small social impact bonus. More expensive to craft.
| Stat | Value |
| ---  | ---   |
| Torso/Neck/Shoulders (Middle) | 63.0% |
| Legs (Middle) | 40.5% |
| Total Mass | 9.0 |
| Total Speed | -0.35 |
| Outer Slot | Free |
| Work | 28,000 (2 items) |
| Crafting Req | 10 |
| Stuff Cost | 120 (Metallic) + 20 Linen

### Immovable Object - Full Plate
Maximum medieval protection. Pawns will never chase down raiders but can hold a breach indefinitely.
| Stat | Value |
| ---  | ---   |
| All body parts (Middle + Shell) | 81.0% |
| Total Mass | 15.0 |
| Total Speed | -0.8 |
| Outer Slot | Blocked |
| Work | 38,000 (1 item) |
| Crafting Req | 12 |
| Stuff Cost | 170 (Metallic)

### Samurai — Samurai Armor
Balanced full-body armour with strong dodge and melee bonuses. Tier 2-level protection but exceptional mobility. Pairs with the Samurai Helmet for maximum melee precision.
| Stat | Value |
| ---  | ---   |
| Full Body Sharp (Steel) | 45.0% |
| Full Body Sharp (Leather) | 37.5% |
| Total Mass | 6.0 |
| Total Speed | -0.1 |
| Outer Slot | Blocked |
| Work | 22,000 (1 item) |
| Crafting Req | 8 |
| Stuff Cost | 100 (Leathery/Metallic) |
| Buffs | +7 MeleeDodgeChance, +5.0 MeleeHitChance

### Daimyo — Daimyo Armor
Functionally identical to Samurai Armour with added social impact for nobles.
| Stat | Value |
| ---  | ---   |
| Full Body Sharp (Steel) | 45.0% |
| Full Body Sharp (Leather) | 37.5% |
| Total Mass | 6.0 |
| Total Speed | -0.1 |
| Outer Slot | Blocked |
| Work | 24,000 (1 item) |
| Crafting Req | 9 |
| Stuff Cost | 100 (Leathery/Metallic) + Gold |
| Buffs | +7 MeleeDodgeChance, +5.0 MeleeHitChance, +0.2 SocialImpact

### Heavy Berserker — Heavy Leather Armor
Heavier leather armour with solid protection. Strong pain threshold and melee bonuses with only a minor speed hit.
| Stat | Value |
| ---  | ---   |
| Full Body Sharp (Leather) | 41.25% |
| Total Mass | 8.0 |
| Total Speed | -0.1 |
| Outer Slot | Blocked |
| Work | 15,000 (1 item) |
| Crafting Req | 8 |
| Stuff Cost | 100 (Leathery) |
| Buffs | +7 MeleeHitChance, +0.075 PainShockThreshold

### Oathbound Warrior — Adorned Warrior Armor
A full-coverage plate-mail hybrid for the warrior-priest. Slower than modular plate but covers all body parts with Middle + Shell layering.
| Stat | Value |
| ---  | ---   |
| Full Body Sharp (Middle + Shell) | 63.0% |
| Total Mass | 10.0 |
| Total Speed | -0.5 |
| Outer Slot | Blocked |
| Work | 32,000 (1 item) |
| Crafting Req | 10 |
| Stuff Cost | 120 (Metallic) + 50 Linen |
| Buffs | +0.05 PainShockThreshold, +15 Cold Insulation

### Oathbound Paladin — Adorned Heavy Plate
Cold-weather full plate with social presence. Identical protection to Full Plate but with extreme insulation for harsh climates.
| Stat | Value |
| ---  | ---   |
| Full Body Sharp (Middle + Shell) | 81.0% |
| Total Mass | 10.0 |
| Total Speed | -0.8 |
| Outer Slot | Blocked |
| Work | 42,000 (1 item) |
| Crafting Req | 12 |
| Stuff Cost | 170 (Metallic) + 5 Gold + 50 Linen |
| Buffs | +0.30 SocialImpact, +15 Cold Insulation

### Gilded Knight — Gilded Full Plate
Prestige armour for nobles and lords. Functionally identical protection to Full Plate with enhanced social impact and a gold requirement.
| Stat | Value |
| ---  | ---   |
| Full Body Sharp (Middle + Shell) | 81.0% |
| Total Mass | 15.0 |
| Total Speed | -0.8 |
| Outer Slot | Blocked |
| Work | 45,000 (1 item) |
| Crafting Req | 13 |
| Stuff Cost | 170 (Metallic) + 10 Gold |
| Buffs | +0.30 SocialImpact

### Juggernaut — Heavy Plate Armor
Overlapping reinforced plates for the heaviest frontline troops. Superior protection even to Full Plate, but at a severe mobility cost.
| Stat | Value |
| ---  | ---   |
| Full Body Sharp (Middle + Shell) | 85.5% |
| Total Mass | 18.0 |
| Total Speed | -1.0 |
| Outer Slot | Blocked |
| Work | 50,000 (1 item) |
| Crafting Req | 13 |
| Stuff Cost | 200 (Metallic) |
| Buffs | None

# Key Changes Summary

- **Full Plate** is the only item anchored to vanilla Plate Armor: `0.90` multiplier, `Middle + Shell`, full body, `-0.8` speed, 38,000 work.
- **Heavy Hauberk** speed penalty drops from `-0.8` (same as Full Plate!) to `-0.2`, making it a genuine mobile chain option.
- **Hauberk** is drastically lighter and cheaper, positioning it as the skirmisher's choice.
- **Brigandine** loses leg coverage (Plate Chausses now pair with it) and drops to Middle layer.
- **Zweihander Cuirass** moves from Shell to Middle, allowing it to be worn under Full Plate or surcoats.
- **Crafting levels** are flattened into three bands: 3–4 for leather, 5–7 for chain, 8–12 for plate. Full Plate anchors at 12 (Expert).
- **Material costs** are reduced for modular/extremity pieces but integrated full-body armor carries a premium.
- **Work costs** are flattened downward across the board; most Tier 2/3 items are 40–60% cheaper to craft.
- **Extremity multipliers** are standardized: Splinted at `0.30`, Plate at `0.45`.
- **Faction armors** trade raw protection for mobility and specialized combat buffs: Samurai gains dodge/melee hit; VFE-M2 gains pain threshold/melee hit.
