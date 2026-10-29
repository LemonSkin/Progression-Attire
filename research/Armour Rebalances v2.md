# Armour Rebalance
The goals of this armour rebalance are as follows:
1. Provide a clear sense of progression throughout the armour tiers - higher tier armours should feel impactful.
2. Balance material costs, work requirements and crafting complexity to place a stronger emphasis on playstyle over resource allocation.
3. Eliminate over- and under-performers. All items should serve a purpose and have a reason to be created.
4. The Medieval Overhaul layering system is being wound back. It introduces annoying micromanagement and is a departure from both vanilla and how other mods implement armour.

Armours from other mods have been changed to give flavour without being strictly better or worse than their MO counterparts.
- **Samurai faction armours** trade 1 tier of protection for melee buffs and dodge buffs.
- **Vanilla Factions Expanded — Medieval 2 leather armours** trade 1 tier of protection for melee buffs and pain shock threshold buffs.
- **VFE-Classical armours** trade protection for mental resilience; the Centurion's decorated set also provides a toggleable ally aura buff. Both accept wood or metal.
- **Adorned armours** are slightly more expensive, provide similar protection, cold insulation buffs, and a small social impact buff.

# Armour Tiers

## Tier 1 — Vest + Padded Chausses
- **Middle**
    - Vest + Padded Chausses + Light Lamellar (Shell)
- **Middle + Shell**
    - Padded Armour

## Tier 2 — Splinted Gloves + Splinted Boots + Chain Coif
- **Middle**
    - Hauberk + Splinted Chausses
- **Middle + Shell**
    - Heavy Hauberk
    - Leather Armour — 2.0 MeleeHitChance, 0.075 PainShockThreshold; helmet provides 1.5 MeleeHitChance, 0.025 PainShockThreshold
    - Ashigaru Armour — 2.0 MeleeHitChance, 2.0 MeleeDodgeChance; helmet provides 1.5 MeleeHitChance, 1.5 MeleeDodgeChance
    - Legionnaire Armour *(Neolithic)* — -0.03 MentalBreakThreshold; helmet provides -0.02 MentalBreakThreshold, -2 Shooting

## Tier 3 — Plate Gloves + Plate Boots + Plate Helmet
- **Middle**
    - Brigandine/Breast Plate/Zweihander Cuirass + Plate Chausses
- **Middle + Shell**
    - Full Plate (steel, normal quality = 81% sharp, 40.5% blunt, 54% heat)
    - Heavy Plate Armour
    - Samurai Armour — 5 MeleeHitChance, 5 MeleeDodgeChance; helmet provides 2.0 MeleeHitChance, 2.0 MeleeDodgeChance
    - Daimyo Armour — 5 MeleeHitChance, 5 MeleeDodgeChance, 0.15 SocialImpact; helmet provides 2.0 MeleeHitChance, 2.0 MeleeDodgeChance, 0.05 SocialImpact
    - Centurion Armour — 0.1 PainShockThreshold ally aura buff; helmet provides -0.05 MentalBreakThreshold, -4 Shooting
    - Heavy Leather Armour — 5 MeleeHitChance, 0.10 PainShockThreshold; helmet provides 2.0 MeleeHitChance, 0.05 PainShockThreshold


Material Multipliers
| Material | Sharp | Blunt | Heat |
|----------|-------|-------|------|
| Fabric | 0.36 | 0 | 0.18 |
| Woody | 0.54 | 0.54 | 0.4 |
| Leathery | 0.75 | 0.24 | 1.5 |
| Metallic | 0.9 | 0.45 | 0.6 |

# Tier 1 Balance (Original → Proposed)

| Item | Layer | Mult | Work | Mass | Delay | Speed | Crafting | Stuff | Coverage | Stat Mods | Proposed Stat Mods |
|------|-------|------|------|------|-------|-------|----------|-------|----------|----------|----------------|
| Padded Chausses | Middle → Middle | 0.30 → 0.30 | 8,000 → **2,000** | 4.0 → **1.5** | 3.0 → **1.5** | — → — | 4 → **4** | 70 → **40** | Legs → Legs | — | — |
| Vest | Middle → Middle | 0.30 → 0.30 | 5,000 → **3,000** | 1.0 → 1.0 | 1.5 → 1.5 | — → — | 3 → **4** | 40 → 40 | Neck, Torso, Shoulders → Neck, Torso, Shoulders | — | — |
| Light Lamellar | Shell → Shell | 0.52 → **0.30** | 12,000 → **6,000** | 4.0 → **2.0** | 10 → **2.5** | — → — | 4 → 4 | 75 → **50** | Neck, Torso, Shoulders → Neck, Torso, Shoulders | — | — |
| Padded Armour | Shell → **Middle + Shell** | 0.52 → **0.40** | 12,000 → **8,000** | 4.0 → 4.0 | 10 → **3.5** | — → — | 4 → 4 | 75 → **100** | Neck, Torso, Shoulders → Neck, Torso, Shoulders, **Legs** | — | — |

**Sharp with fabric:** Padded Chausses 7.2%

**Sharp with leathery:** Vest 22.5% | Padded Chausses 22.5% | Light Lamellar 22.5% | Padded Armour 30.0%


# Tier 2 Balance (Original → Proposed)

| Item | Layer | Mult | Work | Mass | Delay | Speed | Crafting | Stuff | Coverage | Stat Mods | Proposed Stat Mods |
|------|-------|------|------|------|-------|-------|----------|-------|----------|----------|----------------|
| Splinted Gloves | Middle → Middle | 0.378 → **0.30** | 4,000 → 4,000 | 0.5 → **1.0** | 2.5 → **2** | — | 7 → **6** | 25 → **20** | Hands → Hands | -0.05 WorkSpeedGlobal, -2 Shooting | -0.05 WorkSpeedGlobal, -2 Shooting |
| Splinted Boots | Middle → Middle | 0.378 → **0.30** | 4,000 → 4,000 | 0.5 → **1.5** | 2.5 → **2** | -0.05 → -0.05 | 8 → **6** | 35 → **25** | Feet → Feet | — | — |
| Splinted Chausses | Middle → Middle | 0.378 → **0.30** | 19,000 → **6,000** | 9.0 → **2.0** | 3 → **2.5** | — → **-0.05** | 6 → **6** | 70 → **40** | Legs → Legs | — | — |
| Leather Armor | Middle + Shell | 0.65 → **0.40** | 38,000 → **12,000** | 14 → **5** | 15 → **6** | -0.1 → **0** | 8 → **6** | 180 → **80** | Torso, Shoulders, Arms, Legs → **Full body** | 0.10 PainShockThreshold, -0.1 MoveSpeed | **2.0 MeleeHitChance, 0.075 PainShockThreshold, -0.20 SlaveSuppressionOffset** |
| Ashigaru Armor | Middle + Shell | 0.45 → **0.40** | 15,000 → **16,000** | 8 → **5** | 6 → **6** | -0.1 → **0** | 3 → **6** | 100 → **90** | Torso, Shoulders, Arms, Legs → **Full body** | -0.1 MoveSpeed | **2.0 MeleeHitChance, 2.0 MeleeDodgeChance, -0.10 SlaveSuppressionOffset** |
| Legionnaire Armor | Middle + Shell | 0.68 → **0.40** | 42,000 → **12,000** | 12 → **6** | 12 → **8** | **-0.2 → 0** | 7 → **6** | 120 → **100** Metallic/Woody | Full body → Full body | -0.05 MentalBreakThreshold | **-0.03 MentalBreakThreshold, -0.10 SlaveSuppressionOffset** |
| Hauberk | Middle → Middle | 0.55 → **0.50** | 27,000 → **10,000** | 6.0 → **2.0** | 10 → **4** | **-0.4 → -0.1** | 6 → **6** | 80 → **55** | Torso, Neck, Shoulders, Arms → Neck, Torso, Shoulders, Arms | — | **-0.10 SlaveSuppressionOffset** |
| Heavy Hauberk | Shell → **Middle + Shell** | 0.60 → **0.55** | 28,000 → **15,000** | 8.0 → **6.0** | 15 → **6** | **-0.8 → -0.2** | 6 → **7** | 100 → **100** | Full body → Full body | — | **-0.10 SlaveSuppressionOffset** |
| Adorned Mail Shirt | Shell → **Middle + Shell** | 0.65 → **0.55** | 30,000 → **18,000** | 12 → **8** | 15 → **6** | **-0.8 → -0.2** | 8 → **9** | 100 + 70 Linen → **100 + 50 Linen** | Full body → Full body | 15 Insulation_Cold | 15 Insulation_Cold, **-0.20 SlaveSuppressionOffset** |

**Sharp with steel:** Hauberk 45.0% | Heavy Hauberk 49.5% | Splinted Gloves/Boots/Chausses 27.0% | Legionnaire 36.0% (steel) | Ashigaru 36.0% (steel) | Adorned Mail Shirt 49.5%

**Sharp with wood:** Legionnaire 21.6% (wood)

**Sharp with leather:** Leather Armor 30.0% | Ashigaru 30.0% (leather)


# Tier 3 Balance (Original → Proposed)

| Item | Layer | Mult | Work | Mass | Delay | Speed | Crafting | Stuff | Coverage | Stat Mods | Proposed Stat Mods |
|------|-------|------|------|------|-------|-------|----------|-------|----------|----------|----------------|
| Plate Gloves | Middle → Middle | 0.438 → **0.45** | 6,000 → 6,000 | 1.0 → **2.0** | 2.5 → 2.5 | — | 7 → **8** | 35 → **30** | Hands → Hands | -0.1 WorkSpeedGlobal, -4 Shooting | -0.1 WorkSpeedGlobal, -4 Shooting |
| Plate Boots | Middle → Middle | 0.438 → **0.45** | 6,000 → 6,000 | 1.0 → **2.5** | 2.5 → 2.5 | -0.1 → -0.1 | 10 → **8** | 45 → **35** | Feet → Feet | — | — |
| Plate Chausses | Middle → Middle | 0.458 → **0.45** | 35,000 → **8,000** | 6.0 → **3.0** | 3 → 3 | — → **-0.1** | 10 → **8** | 80 → **50** | Legs → Legs | — | — |
| Heavy Leather Armor | Middle + Shell | 1.02 → **0.55** | 38,000 → **15,000** | 18 → **8** | 20 → **10** | -0.8 → **-0.1** | 9 → **8** | 220 → **100** | Torso, Neck, Shoulders, Arms, Legs | -8 MeleeDodgeChance | **5 MeleeHitChance, 0.10 PainShockThreshold, -0.25 SlaveSuppressionOffset** |
| Samurai Armor | Middle + Shell | 0.65 → **0.50** | 33,000 → **28,000** | 10 → **6** | 8 → **10** | -0.1 → -0.1 | 6 → **8** | 175 → **115** | Torso, Neck, Shoulders, Arms, Legs → **Full body** | +1 MeleeDodgeChance | **5 MeleeHitChance, 5 MeleeDodgeChance, -0.15 SlaveSuppressionOffset** |
| Daimyo Armor | Middle + Shell | 0.65 → **0.50** | 35,000 → **30,000** | 10 → **6** | 8 → **10** | -0.1 → -0.1 | 7 → **10** | 200 + 4 Gold → **120 + 5 Gold** | Torso, Neck, Shoulders, Arms, Legs → **Full body** | 0.30 SocialImpact, -0.10 SlaveSuppressionOffset, -0.1 MoveSpeed | **5 MeleeHitChance, 5 MeleeDodgeChance, 0.15 SocialImpact, -0.25 SlaveSuppressionOffset** |
| Centurion Armor | Middle + Shell | 0.73 → **0.60** | 44,000 → **28,000** | 15 → **8** | 15 → **10** | **-0.25 → -0.2** | 7 → **8** | 140 → **130** Metallic/Woody | Full body → Full body | 0.1 PainShockThreshold aura | 0.1 PainShockThreshold aura, **-0.15 SlaveSuppressionOffset** |
| Brigandine | Shell → **Middle** | 0.65 → **0.60** | 32,000 → **15,000** | 15 → **8.0** | 15 → **6** | **-0.6 → -0.25** | 7 → **8** | 100 → **85** | Full body → Neck, Torso, Shoulders, Arms | — | **-0.15 SlaveSuppressionOffset** |
| Breast Plate | Shell → **Middle** | 0.73 → **0.70** | 28,000 → **18,000** | 8.0 → **6.0** | 5 → 5 | **-0.4 → -0.25** | 9 → **9** | 120 → **75** | Neck, Torso, Shoulders → Neck, Torso, Shoulders | — | **-0.15 SlaveSuppressionOffset** |
| Zweihander Cuirass | Shell → **Middle** | 0.73 → **0.70** | 32,000 → **20,000** | 8.0 → **6.0** | 5 → 5 | **-0.4 → -0.25** | 9 → **11** | 120 → **75** (+20 Linen) | Neck, Torso, Shoulders → Neck, Torso, Shoulders | — | **0.10 SocialImpact, -0.20 SlaveSuppressionOffset** |
| Adorned Warrior Armor | Shell → **Middle + Shell** | 0.60 → **0.70** | 38,000 → **32,000** | 15 → **10** | 15 → **10** | **-0.8 → -0.5** | 8 → **11** | 120 + 70 Linen → **120 + 50 Linen** | Full body → Full body | 15 Insulation_Cold | 15 Insulation_Cold, **-0.25 SlaveSuppressionOffset** |
| Light Plate Armour | Middle + Shell | 0.90 | 18,000 → **28,000** | 12 → **8** | 10 → **8** | -0.20 → **-0.40** | 8 → **10** | 130 → **110** Metallic/Woody | Torso, Shoulders, Arms → **Torso, Neck, Shoulders** | — | **-0.15 SlaveSuppressionOffset** |
| Vanilla Plate Armor | Middle + Shell | 0.90 | 38,000 | 15 | 15 | -0.8 | 7 → **10** | 170 Metallic/Woody | Full body | — | **-0.15 SlaveSuppressionOffset** |
| Full Plate | Shell → **Middle + Shell** | 0.73 → **0.90** | 38,000 → 38,000 | 15 → 15 | 15 → 15 | -0.8 → -0.8 | 7 → **10** | 150 → **170 Metallic/Woody** | Full body → Full body | — | **-0.15 SlaveSuppressionOffset** |
| Adorned Full Plate | Shell → **Middle + Shell** | 0.75 → **0.90** | 45,000 → **42,000** | 17 → **15** | 20 → **15** | **-1.2 → -0.8** | 12 → **12** | 200 + 5 Gold + 70 Linen → **170 + 5 Gold + 50 Linen** | Full body → Full body | 15 Insulation_Cold, 0.30 SocialImpact, -0.10 SlaveSuppressionOffset | 15 Insulation_Cold, **0.10 SocialImpact, -0.25 SlaveSuppressionOffset** |
| Gilded Full Plate | Shell → **Middle + Shell** | 0.73 → **0.90** | 50,000 → **45,000** | 17 → **15** | 20 → **15** | -0.8 → -0.8 | 16 → **14** | 150 + 5 Gold → **170 + 10 Gold** | Full body → Full body | 0.30 SocialImpact, -0.10 SlaveSuppressionOffset | **0.20 SocialImpact, -0.25 SlaveSuppressionOffset** |
| Heavy Plate Armor | Middle + Shell | 1.02 → **0.95** | 60,000 → **50,000** | 20 → **18** | 20 → **15** | **-1.2 → -1.0** | 9 → **12** | 240 → **200** Metallic | Full body → Full body | -20 MeleeDodgeChance | **-0.25 SlaveSuppressionOffset** |

**Sharp with steel:** Brigandine 54.0% | Breast Plate 63.0% | Zweihander 63.0% | Adorned Warrior 63.0% | **Full Plate 81.0%** | Light Plate Armour 81.0% (chest only) | Adorned Full Plate 81.0% | Gilded Full Plate 81.0% | Heavy Plate Armor 85.5% | Plate Gloves/Boots/Chausses 40.5% | Samurai/Daimyo 45.0% (steel) | Centurion 54.0% (steel)

**Sharp with wood:** Centurion 32.4% (wood) | Full Plate/Vanilla Plate Armor 48.6% (wood)

**Sharp with leather:** Heavy Leather 41.25% | Samurai/Daimyo 37.5% (leather)

# Key Changes Summary

- **Full Plate** and **Vanilla Plate Armor** are intentionally interchangeable post-rebalance: identical `0.90` multiplier, `Middle + Shell`, full body, `-0.8` speed, 38,000 work, 170 Metallic/Woody, craft 10.
- **Heavy Hauberk** speed penalty drops from `-0.8` (same as Full Plate!) to `-0.2`, making it a genuine mobile chain option.
- **Hauberk** is drastically lighter and cheaper, positioning it as the skirmisher's choice.
- **Brigandine** loses leg coverage (Plate Chausses now pair with it) and drops to Middle layer.
- **Zweihander Cuirass** is a prestige officer variant of the Breast Plate: identical protection (`0.70`) but with `0.10 SocialImpact`, a Linen requirement, and higher crafting skill (11 vs 9). Moves from Shell to Middle, allowing it to be worn under Full Plate or surcoats.
- **Crafting levels** follow tier-based bands: T0–T1 padded/leather at 3–4, T2 chain entry at 6 (Chainveil at 7, adorned variants +2), T3 plate entry at 8 with anchor at 10 for Full Plate, prestige variants reaching 14 (Master).
- **Material costs** are reduced for modular/extremity pieces but integrated full-body armor carries a premium.
- **Work costs** are flattened downward across the board; most Tier 2/3 items are 40–60% cheaper to craft.
- **Extremity multipliers** are standardized: Splinted at `0.30`, Plate at `0.45`.
- **Faction armors** trade raw protection for mobility and specialized combat buffs: Samurai gains dodge/melee hit; VFE-M2 gains pain threshold/melee hit.
- **SocialImpact** values listed are body armour contributions only; matching helmets carry an additional share, so the total per-set social impact is split across both pieces (see tier descriptions above).
- **Legionnaire Armour** is a Neolithic-age unlock and is intentionally outclassed by Medieval-tier chain armours in raw protection.
