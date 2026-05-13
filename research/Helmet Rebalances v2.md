# Rebalance
- Move the decision-making from resources to playstyle.
- Unwind the Medieval Overhaul layering system 
    - DankPyon_InnerHelmet should be removed in favour of OverHead
    - DankPyon_Hood is okay but items should be rebalanced to not provide armour as much as possible
    - DankPyon_Attachment is okay but items should rebalanced or moved to the Shell layer where appropriate.


Material Multipliers
| Material | Sharp | Blunt | Heat |
|----------|-------|-------|------|
| Fabric | 0.36 | 0 | 0.18 |
| Leathery | 0.75 | 0.24 | 1.5 |
| Metallic | 0.9 | 0.45 | 0.6 |

# Tier 0 Balance (Original → Proposed)
These are the cloth coifs, they're being moved from InnerHelmet to Overhead.

| Item | Layer | Mult | Work | Mass | Delay | Stuff | Coverage |
|------|-------|------|------|------|-------|-------|----------|
| Cap | Overhead | 0.20 → **0.15** | 1,800 | 0.12 | 0.8 | 25 Fabric/Leathery | UpperHead |
| Zweihander Hat | DankPyon_Hood → **Overhead** | 0.30 → **0.20** | 2,500 → **2,000** | 0.5 | 1.5 → **1.0** | 55 Fabric | UpperHead |
| Coif | InnerHelmet → **Overhead** | 0.25 → **0.20** | 2,200 → **1,500** | 0.07 | 0.8 → **0.5** | 25 Fabric | UpperHead |
| Arming Cap | InnerHelmet → **Overhead** | 0.25 → **0.20** | 2,200 → **1,500** | 0.15 | 0.8 → **0.5** | 25 Fabric | UpperHead |
| Padded Helmet | Overhead | 0.35 → **0.25** | 3,500 → **2,000** | 0.15 | 0.8 → **0.5** | 35 → **30** Fabric | FullHead |
| Full Arming Cap | InnerHelmet → **Overhead** | 0.30 → **0.25** | 2,500 → **2,000** | 0.20 | 0.8 → **0.5** | 30 Fabric | FullHead |

**Sharp with fabric:** Cap 5.4% | Zweihander Hat 7.2% | Coif 7.2% | Arming Cap 7.2% | Padded Helmet 9.0% | Full Arming Cap 9.0%

## Roles
### Commander — Zweihander Hat
A thick, ornamented hat worn by military nobles and officers. Protective simply due to its size and shape, but mainly worn for decoration and as a status symbol.
| Stat | Value |
| ---  | ---   |
| UpperHead Sharp (Fabric) | 7.2% |
| Total Mass | 0.5 |
| Total Speed | 0 |
| Work | 2,000 |
| Crafting Req | — |
| Stuff Cost | 55 (Fabric) |
| Buffs | +0.10 PainShockThreshold, +0.15 SocialImpact |

### Soldier's Coif
Light fabric cap for basic head protection. The simplest military headgear, identical in protection to the Arming Cap but lighter.
| Stat | Value |
| ---  | ---   |
| UpperHead Sharp (Fabric) | 7.2% |
| Total Mass | 0.07 |
| Total Speed | 0 |
| Work | 1,500 |
| Crafting Req | — |
| Stuff Cost | 25 (Fabric) |
| Buffs | — |

### Padded Cap — Arming Cap
Thickly padded cap worn by soldiers. Slightly heavier than the coif but otherwise identical protection.
| Stat | Value |
| ---  | ---   |
| UpperHead Sharp (Fabric) | 7.2% |
| Total Mass | 0.15 |
| Total Speed | 0 |
| Work | 1,500 |
| Crafting Req | — |
| Stuff Cost | 25 (Fabric) |
| Buffs | — |

### Full Hood — Full Arming Cap
Thick padded hood covering the entire head including face. Maximum fabric protection at the cost of slight bulk.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Fabric) | 9.0% |
| Total Mass | 0.20 |
| Total Speed | 0 |
| Work | 2,000 |
| Crafting Req | — |
| Stuff Cost | 30 (Fabric) |
| Buffs | — |

### Archer — Cap
Light feathered cap for marksmen. Negligible protection but improves shooting focus.
| Stat | Value |
| ---  | ---   |
| UpperHead Sharp (Fabric) | 5.4% |
| Total Mass | 0.12 |
| Total Speed | 0 |
| Work | 1,800 |
| Crafting Req | — |
| Stuff Cost | 25 (Fabric/Leathery) |
| Buffs | +2 ShootingAccuracyPawn |

### Militia — Padded Helmet
Simple padded fabric hood covering the entire head for levy troops. Maximum fabric-tier protection with minimal cost.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Fabric) | 9.0% |
| Total Mass | 0.15 |
| Total Speed | 0 |
| Work | 2,000 |
| Crafting Req | — |
| Stuff Cost | 30 (Fabric) |
| Buffs | — |

# Tier 1 Balance (Original → Proposed)

| Item | Layer | Mult | Work | Mass | Delay | Stuff | Coverage | Shooting |
|------|-------|------|------|------|-------|-------|----------|----------|
| Padded Nasal Helm | Overhead + InnerHelmet → **Overhead** | 0.45 → **0.40** | 12,000 → **8,000** | 2.75 → **2.0** | 4 → **3** | 55 Metal + 10 Cloth | FullHead | **-1** |
| Padded Kettle Helm | Overhead + InnerHelmet → **Overhead** | 0.45 → **0.40** | 12,000 → **8,000** | 2.75 → **2.0** | 4 → **3** | 55 Metal + 10 Cloth | FullHead | **-1** |
| Padded Flat Top | Overhead + InnerHelmet → **Overhead** | 0.45 → **0.40** | 12,000 → **8,000** | 2.75 → **2.0** | 4 → **3** | 55 Metal + 10 Cloth | FullHead | **-1** |

**Sharp with steel:** Padded Helmets 36.0%

## Roles
### Footman — Padded Helmets
Entry-level metallic helmet with full head coverage. The thick padded coif underneath provides insulation but restricts vision slightly. Three visual variants (Nasal, Kettle, Flat Top) with identical protection.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 36.0% |
| Total Mass | 2.0 |
| Total Speed | 0 |
| Work | 8,000 (1 item) |
| Crafting Req | 4 |
| Stuff Cost | 55 (Metallic) + 10 Cloth |
| Penalty | -1 ShootingAccuracyPawn |

# Tier 2 Balance (Original → Proposed)

| Item | Layer | Mult | Work | Mass | Delay | Stuff | Coverage | Shooting |
|------|-------|------|------|------|-------|-------|----------|----------|
| Chain Coif | Overhead | 0.40 → **0.45** | 8,000 → **5,000** | 2.0 → **1.5** | 4 → **3** | 50 → **40** Metal | UpperHead | — → **0** |
| Ashigaru Helmet | Overhead | 0.35 → **0.45** | 2,000 → **6,000** | 1.0 → **1.5** | 1.5 → **3** | 35 → **45** Metallic/Leathery | UpperHead | — → **0** |
| Full Chain Coif | Overhead | 0.45 → **0.50** | 10,000 | 2.0 → **2.5** | 4 → **6** | 55 Metal | FullHead | — → **-3** |
| Chain Nasal Helm | Overhead | 0.50 | 16,000 → **10,000** | 3.0 → **2.5** | 8 → **6** | 60 → **55** Metal | FullHead | **-1.5 → -3** |
| Chain Nasal Helm (Red) | Overhead | 0.50 | 16,000 → **10,000** | 3.0 → **2.5** | 8 → **6** | 60 → **55** Metal | FullHead | **-1.5 → -3** |
| Chain Kettle Helm | Overhead | 0.50 | 16,000 → **10,000** | 3.0 → **2.5** | 8 → **6** | 60 → **55** Metal | FullHead | **-1.5 → -3** |
| Chain Flat Top | Overhead | 0.50 | 16,000 → **10,000** | 3.0 → **2.5** | 8 → **6** | 60 → **55** Metal | FullHead | **-1.5 → -3** |
| Leather Helmet | Overhead | 0.35 → **0.40** | 3,200 → **8,000** | 2.0 → **2.5** | 2.5 → **4** | 40 → **50** Leathery | UpperHead | **-5 → 0** |
| Chainveil Helmet | Overhead | 0.50 → **0.55** | 18,000 → **12,000** | 3.5 → **3.0** | 8 → **6** | 60 Metal | FullHead | **-3 → -3** |
| Adorned Heavy Chain Coif | Overhead | 0.55 → **0.55** | 12,000 → **12,000** | 2.0 → **2.0** | 4 → **6** | 65 Metal + 20 Linen | FullHead | — → **-3** |
| Adorned Chainveil Helmet | Overhead | 0.50 → **0.55** | 21,000 → **15,000** | 3.5 → **3.5** | 8 → **6** | 80 Metal + 30 Linen | FullHead | **-3 → -3** |

**Sharp with steel:** Chain Coif 40.5% | Ashigaru 40.5% (steel) / 33.75% (leather) | Chain Nasal/Kettle/Flat Top/Full Coif 45.0% | Leather Helmet 30.0% (leather) | Chainveil 49.5% | Adorned Heavy Chain Coif 49.5% | Adorned Chainveil 49.5%

## Roles

### Skirmisher — Chain Coif
Simple chainmail hood for mobility-focused troops. Covers the top of the head only, leaving the face exposed. Cheaper than the Ashigaru Helmet but lacks its deflection properties.
| Stat | Value |
| ---  | ---   |
| UpperHead Sharp (Steel) | 40.5% |
| Total Mass | 1.5 |
| Total Speed | 0 |
| Work | 5,000 (1 item) |
| Crafting Req | 5 |
| Stuff Cost | 40 (Metallic) |
| Penalty | None |

### Frontline Infantry — Chain Nasal / Kettle / Flat Top
Chainmail coif combined with a steel helmet, or a full chain hood. Full head coverage with moderate vision obstruction. All Tier 2 chain helmets share the same -3 shooting penalty; choices are purely visual.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 45.0% |
| Total Mass | 2.5 |
| Total Speed | 0 |
| Work | 10,000 (1 item) |
| Crafting Req | 6 |
| Stuff Cost | 55 (Metallic) |
| Penalty | -3 ShootingAccuracy |

**Variant features:**
- **Chain Kettle** — Wide brim, identical stats
- **Chain Nasal** — Standard noseguard, identical stats
- **Chain Flat Top**
- **Chain Nasal (Red)** — Bandana variant for visual authority

### Heavy Infantry — Chainveil
Fully enclosed chain helmet for shock troops who don't need to shoot. Maximum chain-tier protection at the cost of severe vision restriction.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 49.5% |
| Total Mass | 3.0 |
| Total Speed | 0 |
| Work | 12,000 (1 item) |
| Crafting Req | 7 |
| Stuff Cost | 60 (Metallic) |
| Penalty | -3 ShootingAccuracy |

### Oathbound Initiate — Adorned Heavy Chain Coif
Ornate heavy chain coif with a plate noseguard. Matches standard Chainveil protection but trades material efficiency for cold insulation and a minor social presence. Pairs with the Adorned Mail Shirt.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 49.5% |
| Total Mass | 2.0 |
| Total Speed | 0 |
| Work | 12,000 (1 item) |
| Crafting Req | 5 |
| Stuff Cost | 65 (Metallic) + 20 Linen |
| Penalty | -3 ShootingAccuracy |

### Oathbound Warrior — Adorned Chainveil Helmet
Reinforced flat-top helmet with face-plate and mail coif. Maximum chain-tier head protection with a linen lining for warrior-priests. Pairs with the Adorned Warrior Armor.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 49.5% |
| Total Mass | 3.5 |
| Total Speed | 0 |
| Work | 15,000 (1 item) |
| Crafting Req | 7 |
| Stuff Cost | 80 (Metallic) + 30 Linen |
| Penalty | -3 ShootingAccuracy |

### Ashigaru — Ashigaru Helmet
Light conical kabuto designed to deflect blows. UpperHead coverage with unrestricted vision, paired with Ashigaru Armour for exceptional evasion.
| Stat | Value |
| ---  | ---   |
| UpperHead Sharp (Steel) | 40.5% |
| UpperHead Sharp (Leather) | 33.75% |
| Total Mass | 1.5 |
| Total Speed | 0 |
| Work | 6,000 (1 item) |
| Crafting Req | 5 |
| Stuff Cost | 45 (Metallic/Leathery) |
| Buffs | +2.0 MeleeDodgeChance |
| Penalty | None |

### Leather Fighter — Leather Helmet
Open-faced leather helmet for aggressive skirmishers. Unrestricted vision aids melee awareness at the cost of lower raw protection.
| Stat | Value |
| ---  | ---   |
| UpperHead Sharp (Leather) | 30.0% |
| Total Mass | 2.5 |
| Total Speed | 0 |
| Work | 8,000 (1 item) |
| Crafting Req | 5 |
| Stuff Cost | 50 (Leathery) |
| Buffs | +1.5 MeleeHitChance |
| Penalty | None |

# Tier 3 Balance (Original → Proposed)

| Item | Layer | Mult | Work | Mass | Delay | Stuff | Coverage | Shooting |
|------|-------|------|------|------|-------|-------|----------|----------|
| Open Bascinet | Overhead | 0.55 → **0.60** | 16,000 → **15,000** | 3.5 | 8 → **6** | 70 → **80** Metal | FullHead | **-2.5 → -6** |
| Zweihander Helm | Overhead | 0.55 → **0.60** | 16,000 → **15,000** | 3.5 | 8 → **6** | 70 → **80** Metal | FullHead | — → **-6** |
| Samurai Helmet | Overhead | 0.50 → **0.60** | 8,000 → **12,000** | 2.0 → **3.0** | 3 → **6** | 55 → **70** Metallic/Leathery | UpperHead | — → **-3** |
| Daimyo Helmet | Overhead | 0.50 → **0.60** | 10,000 → **14,000** | 2.0 → **3.0** | 3 → **6** | 75 → **70** Metallic/Leathery + 2 Gold | UpperHead | — → **-3** |
| Heavy Barbute | Overhead | 0.55 → **0.60** | 16,000 → **15,000** | 3.5 | 8 → **6** | 70 → **80** Metal | FullHead | **-3 → -6** |
| Closed Bascinet | Overhead | 0.65 → **0.60** | 20,000 → **15,000** | 3.5 | 10 → **6** | 80 Metal | FullHead | **-3 → -6** |
| Wolf-Ribs Bascinet | Overhead | 0.65 → **0.60** | 20,000 → **15,000** | 3.5 | 10 → **6** | 80 Metal | FullHead | **-3 → -6** |
| Klappviser Bascinet | Overhead | 0.65 → **0.60** | 20,000 → **15,000** | 3.5 | 10 → **6** | 80 Metal | FullHead | **-3 → -6** |
| Klappviser Barbute | Overhead | 0.65 → **0.60** | 20,000 → **15,000** | 3.5 | 10 → **6** | 80 Metal | FullHead | **-3 → -6** |
| Hounskull Helmet | Overhead | 0.65 → **0.60** | 20,000 → **15,000** | 3.5 | 10 → **6** | 80 Metal | FullHead | **-3 → -6** |
| Sallet (Visored) | Overhead | 0.65 → **0.60** | 20,000 → **15,000** | 3.5 | 10 → **6** | 80 Metal | FullHead | **-3 → -6** |
| Sallet (Bellow Face) | Overhead | 0.65 → **0.60** | 20,000 → **15,000** | 3.5 | 10 → **6** | 80 Metal | FullHead | **-3 → -6** |
| Sallet (Gryphon) | Overhead | 0.65 → **0.60** | 20,000 → **15,000** | 3.5 | 10 → **6** | 80 Metal | FullHead | **-3 → -6** |
| Great Helm | Overhead | 0.65 → **0.60** | 20,000 → **15,000** | 3.5 | 10 → **6** | 80 Metal | FullHead | **-3 → -6** |
| Heraldic Great Helm | Overhead | 0.65 → **0.60** | 20,000 → **15,000** | 3.5 | 10 → **6** | 80 Metal | FullHead | **-3 → -6** |
| Heavy Leather Helmet | Overhead | 0.55 → **0.60** | 12,000 → **15,000** | 3.5 | 4 → **6** | 70 → **80** Leathery | FullHead | **-8 → -3** |
| Heavy Plate Helmet | Overhead | 0.55 → **0.70** | 12,000 → **15,000** | 3.5 | 4 → **6** | 70 → **80** Metallic | FullHead | **-8 → -6** |
| Armet | Overhead | 0.70 → **0.60** | 25,000 → **15,000** | 3.5 | 10 → **8** | 90 → **80** Metal | FullHead | **-3 → -6** |
| Gilded Armet | Overhead | 0.70 → **0.60** | 25,000 → **20,000** | 3.5 | 10 → **8** | 90 Metal + 2 Gold | FullHead | **-3 → -6** |
| Adorned Great Helm | Overhead | 0.65 → **0.60** | 24,000 → **18,000** | 3.5 | 10 → **8** | 80 Metal + 30 Linen | FullHead | **-3 → -6** |

**Sharp with steel:** Open Bascinet 54.0% | Zweihander Helm 54.0% | Samurai 54.0% (steel) / 45.0% (leather) | Daimyo 54.0% (steel) / 45.0% (leather) | Heavy Barbute 54.0% | Standard Plate 54.0% | Heavy Leather 45.0% (leather) | Armet 54.0% | Gilded Armet 54.0% | Adorned Great Helm 54.0% | Heavy Plate Helmet 63.0%

*(Note: Original defName had typo "Heavy Barbrute" — should be corrected to "Heavy Barbute")*

## Roles

### Knight — Open Bascinet
Plate helmet with a retractable visor. Full-head protection with severe vision restriction. Standard cost and mass shared across all enclosed plate helmets; choices are visual.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 54.0% |
| Total Mass | 3.5 |
| Total Speed | 0 |
| Work | 15,000 (1 item) |
| Crafting Req | 8 |
| Stuff Cost | 80 (Metallic) |
| Penalty | -6 ShootingAccuracy |

### Landsknecht — Zweihander Helm
Ornate plate helmet adorned with a flamboyant feathered hat. Identical protection to all standard enclosed plate helmets with added social presence for status-displaying warriors.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 54.0% |
| Total Mass | 3.5 |
| Total Speed | 0 |
| Work | 15,000 (1 item) |
| Crafting Req | 8 |
| Stuff Cost | 80 (Metallic) |
| Buffs | +0.15 SocialImpact |
| Penalty | -6 ShootingAccuracy

*(Variants: Amboise, Soren, Oswin, Hesse — identical stats, different visuals)*

### Dreadnought — Heavy Barbute
Solid plate barbute for the heaviest frontline troops. Maximum head protection at the cost of severe vision restriction. One of many heavy plate helmets sharing identical protection; choices are visual.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 54.0% |
| Total Mass | 3.5 |
| Total Speed | 0 |
| Work | 15,000 (1 item) |
| Crafting Req | 8 |
| Stuff Cost | 80 (Metallic) |
| Penalty | -6 ShootingAccuracy |

### Crusader — Great Helm / Bascinet / Sallet / Hounskull
Full-face plate helmets providing maximum standard-tier protection. All share identical stats; the choice is purely aesthetic and atmospheric. Includes Closed Bascinet, Wolf-Ribs, Klappviser variants, Hounskull, all Sallet variants, Great Helm, and Heraldic Great Helms.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 54.0% |
| Total Mass | 3.5 |
| Total Speed | 0 |
| Work | 15,000 (1 item) |
| Crafting Req | 8 |
| Stuff Cost | 80 (Metallic) |
| Penalty | -6 ShootingAccuracy |

### Oathbound Paladin — Adorned Great Helm
Ornamented great helm for the oathbound elite. Identical protection to standard plate helmets but with a linen lining for warmth and religious bearing. Pairs with the Adorned Heavy Plate.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 54.0% |
| Total Mass | 3.5 |
| Total Speed | 0 |
| Work | 18,000 (1 item) |
| Crafting Req | 8 |
| Stuff Cost | 80 (Metallic) + 30 Linen |
| Buffs | +0.30 SocialImpact, +0.10 PainShockThreshold |
| Penalty | -6 ShootingAccuracy |

### Champion — Armet
Masterwork plate helmet for distinguished warriors and champions. Elegant craftsmanship with enhanced social presence. Functionally identical to the Zweihander Helm but with a different visual profile.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 54.0% |
| Total Mass | 3.5 |
| Total Speed | 0 |
| Work | 15,000 (1 item) |
| Crafting Req | 8 |
| Stuff Cost | 80 (Metallic) |
| Buffs | +0.15 SocialImpact |
| Penalty | -6 ShootingAccuracy |

### Lord — Gilded Armet
Gilded variant of the Armet for nobility. Identical protection with enhanced social presence and a gold requirement.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 54.0% |
| Total Mass | 3.5 |
| Total Speed | 0 |
| Work | 20,000 (1 item) |
| Crafting Req | 12 |
| Stuff Cost | 90 (Metallic) + 2 Gold |
| Buffs | +0.35 SocialImpact |
| Penalty | -6 ShootingAccuracy |

### Samurai — Samurai Helmet
Open-faced kabuto for the warrior class. UpperHead coverage with less vision restriction than enclosed plate. Contributes melee precision to the Samurai set.
| Stat | Value |
| ---  | ---   |
| UpperHead Sharp (Steel) | 54.0% |
| UpperHead Sharp (Leather) | 45.0% |
| Total Mass | 3.0 |
| Total Speed | 0 |
| Work | 12,000 (1 item) |
| Crafting Req | 7 |
| Stuff Cost | 70 (Metallic/Leathery) |
| Buffs | +2.0 MeleeHitChance |
| Penalty | -3 ShootingAccuracy |

### Shogun — Daimyo Helmet
Elaborate eastern helm for battlefield commanders. Open-faced design allows directing troops while the lord's presence suppresses dissent.
| Stat | Value |
| ---  | ---   |
| UpperHead Sharp (Steel) | 54.0% |
| UpperHead Sharp (Leather) | 45.0% |
| Total Mass | 3.0 |
| Total Speed | 0 |
| Work | 14,000 (1 item) |
| Crafting Req | 7 |
| Stuff Cost | 70 (Metallic/Leathery) + 2 Gold |
| Buffs | +0.30 SocialImpact, SlaveSuppressionOffset -0.1 |
| Penalty | -3 ShootingAccuracy |

### Juggernaut — Heavy Plate Helmet
Overlapping reinforced steel plates for the heaviest frontline troops. Superior protection even to standard plate helmets, but at the cost of greater weight and material requirements.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Steel) | 63.0% |
| Total Mass | 3.5 |
| Total Speed | 0 |
| Work | 15,000 (1 item) |
| Crafting Req | 9 |
| Stuff Cost | 80 (Metallic) |
| Penalty | -6 ShootingAccuracy |

### Northern Raider — Heavy Leather Helmet
Full-coverage leather helmet for cold-climate warriors. Flexible leather allows larger eye slits than rigid plate, imposing a lighter vision restriction.
| Stat | Value |
| ---  | ---   |
| FullHead Sharp (Leather) | 45.0% |
| Total Mass | 3.5 |
| Total Speed | 0 |
| Work | 15,000 (1 item) |
| Crafting Req | 8 |
| Stuff Cost | 80 (Leathery) |
| Buffs | +2.0 Cold Insulation Multiplier |
| Penalty | -3 ShootingAccuracy |
