using ICities;
using UnityEngine;
using ColossalFramework;
using ColossalFramework.Globalization;
using System;
using System.Collections.Generic;

namespace DifficultyTuningMod
{
	public class DTMLang : MonoBehaviour {

		public static string GameLanguage;
		public static Dictionary<string, string> nl = new Dictionary<string, string>();
		public static Dictionary<string, string> de = new Dictionary<string, string>();
		public static Dictionary<string, string> it = new Dictionary<string, string>();
		public static Dictionary<string, string> en = new Dictionary<string, string> ();

		public static string text (string index) {

			ColossalFramework.SavedString lang_setting = new ColossalFramework.SavedString("localeID", "gameSettings");
			if (GameLanguage == null || GameLanguage != lang_setting.value) {

				try {
					GameLanguage = lang_setting.value;
					if (GameLanguage == "nl") {
						nl = new Dictionary<string, string> ();

						nl ["MOD_NAME"] = "Moeilijkheidstuningmod";
						nl ["MOD_DESCRIPTION"] = "Variatie in de moeilijkheidsgraad. Geen wijzigingen aan het spelverloop.";

						nl ["DTM_OPTIONS"] = "Instellingen van Moeilijkheidstuningsmod";
						nl ["DIFFICULTY_LEVEL"] = "Moeilijkheidsgraad";
						nl ["CUSTOM_OPTIONS"] = "Aangepaste instellingen (enkel gebruikt indien aangepaste moeilijkheidsgraad gekozen)";
						nl ["CONSTRUCTION_COST"] = "Bouwkosten (van alles behalve wegen):";
						nl ["ROAD_CONSTRUCTION_COST"] = "Wegenbouwkkosten:";
						nl ["MAINTENANCE_COST"] = "Onderhoudskosten (van alles behalve wegen):";
						nl ["ROAD_MAINTENANCE_COST"] = "Wegonderhoudskosten:";
						nl ["AREA_COST_MULTIPLIER"] = "Vermenigvuldigingsfactor voor aankoop gebieden:";
						nl ["DEMAND_OFFSET"] = "Vraagimpuls:  -->  formule voor vraag: (Vraag - Impuls) * vermenigvuldigingsfactor";
						nl ["DEMAND_MULTIPLIER"] = "Vraagvermenigvuldigingsfactor";
						nl ["REWARD"] = "Beloning (hoeveelheid geld die je ontvangt indien een mijlpaal berijkt wordt):";
						nl ["RELOCATION_COST"] = "Verhuizingskosten van nutsgebouwen:";
						nl ["TARGET_RESIDENTIAL"] = "Grondrichtprijzen voor woongebouwen om op te waarderen (niveau 2, 3, 4, 5):";
						nl ["TARGET_COMMERCIAL"] = "Grondrichtprijzen voor handelsgebouwen om op te waarderen (niveau 2, 3):";
						nl ["TARGET_INDUSTRIAL"] = "Grondrichtprijzen voor industriegebouwen om op te waarderen (niveau 2, 3):";
						nl ["TARGET_OFFICE"] = "Grondrichtprijzen voor kantoorgebouwen om op te waarderen (niveau 2, 3):";
						
						nl ["Easy"] = "Gemakkelijk";
						nl ["Normal"] = "Normaal";
						nl ["Medium"] = "Gemiddeld";
						nl ["Hard"] = "Moeilijk";
						nl ["Advanced"] = "Vergevorderd";
						nl ["Expert"] = "Expert";
						nl ["Challenge"] = "Uitdaging";
						nl ["Impossible"] = "Onmogelijk";
						nl ["Custom"] = "Aangepast";
						return nl [index];
					} else if (GameLanguage == "de") {
						de = new Dictionary<string, string> ();

						de ["MOD_NAME"] = "Schwierigkeitstuningmod";
						de ["MOD_DESCRIPTION"] = "Variation in der Schwierigkeitsgrad. Keine Änderungen am Spielverlauf.";
						
						de ["DTM_OPTIONS"] = "Einstellungen Schwierigkeitsgradtuningsmod";
						de ["DIFFICULTY_LEVEL"] = "Schwierigkeitsgrad";
						de ["CUSTOM_OPTIONS"] = "Angepaßte Einstellungen (nur verwendet wenn angepaßte Schwierigkeitsgrad gewählt)";
						de ["CONSTRUCTION_COST"] = "Baukosten (alles außer Straßen):";
						de ["ROAD_CONSTRUCTION_COST"] = "Straßenbau-Kosten:";
						de ["MAINTENANCE_COST"] = "Unterhaltskosten (alles außer Straßen):";
						de ["ROAD_MAINTENANCE_COST"] = "Straßenunterhaltskosten:";
						de ["AREA_COST_MULTIPLIER"] = "Multiplikator für Ankauf Gebiete:";
						de ["DEMAND_OFFSET"] = "Frage-impuls:  -->  Formel für Frage: (Frage - Impuls) * Multiplikator";
						de ["DEMAND_MULTIPLIER"] = "Fragemultiplikationsfaktor";
						de ["REWARD"] = "Belohnung (Betrag, den du erhaltet, wenn einen Meilenstein erreicht wird):";
						de ["RELOCATION_COST"] = "Umzugskosten von Nutzgebäude:";
						de ["TARGET_RESIDENTIAL"] = "Bodenrichtpreise für Wohngebäude zu verbesseren (Stufe 2, 3, 4, 5):";
						de ["TARGET_COMMERCIAL"] = "Bodenrichtpreise für Gewerbgebäude zu verbesseren (Stufe 2, 3):";
						de ["TARGET_INDUSTRIAL"] = "Bodenrichtpreise für Industriegebäude zu verbesseren (Stufe 2, 3):";
						de ["TARGET_OFFICE"] = "Bodenrichtpreise für Bürogebäude zu verbesseren (Stufe 2, 3):";
						
						de ["Easy"] = "Einfach";
						de ["Normal"] = "Normal";
						de ["Medium"] = "Gemittelt";
						de ["Hard"] = "Schwer";
						de ["Advanced"] = "Fortgeschritten";
						de ["Expert"] = "Expert";
						de ["Challenge"] = "Herausforderung";
						de ["Impossible"] = "Unmöglich";
						de ["Custom"] = "Angepast";
						return de [index];
					} else if (GameLanguage == "it") {
						it = new Dictionary<string, string> ();

						it ["MOD_NAME"] = "Mod Sintonia di Difficultà";
						it ["MOD_DESCRIPTION"] = "Varietà di livelli di difficoltà. Nessuni modificazioni nel gameplay.";

						it ["DTM_OPTIONS"] = "Opzioni Mod Sintonia di Difficultà";
						it ["DIFFICULTY_LEVEL"] = "Livello di difficoltà";
						it ["CUSTOM_OPTIONS"] = "Opzioni personalizzate (efficace se è stato selezionato livello difficoltà personalizzate)";
						it ["CONSTRUCTION_COST"] = "Costo di costruzione (tutto tranne strade):";
						it ["ROAD_CONSTRUCTION_COST"] = "Costo di costruzione strade:";
						it ["MAINTENANCE_COST"] = "Costo di manutenzione (tutti tranne strade):";
						it ["ROAD_MAINTENANCE_COST"] = "Costo di manutenzione strade:";
						it ["AREA_COST_MULTIPLIER"] = "Moltiplicatore costi di aree:";
						it ["DEMAND_OFFSET"] = "Impulso di domanda:  -->  formula per domanda: (Domanda - Impulso) * moltiplicatore";
						it ["DEMAND_MULTIPLIER"] = "Moltiplicatore di domanda";
						it ["REWARD"] = "Ricompensa (fundi che si ottiene quando si raggiunge una pietra miliare):";
						it ["RELOCATION_COST"] = "Costi trasferimenti dei edifici di utilità:";
						it ["TARGET_RESIDENTIAL"] = "Obiettivo valore del terreno per edifici residenziale a salire livello (Livello 2, 3, 4, 5):";
						it ["TARGET_COMMERCIAL"] = "Obiettivo valore del terreno per edifici commerciale a salire livello (Livello 2, 3):";
						it ["TARGET_INDUSTRIAL"] = "Obiettivo valore del terreno per edifici industriale a salire livello (Livello 2, 3):";
						it ["TARGET_OFFICE"] = "Obiettivo valore del terreno per edifici uffuci a salire livello (Livello 2, 3):";
						
						it ["Easy"] = "Facile";
						it ["Normal"] = "Normale";
						it ["Medium"] = "Media";
						it ["Hard"] = "Difficile";
						it ["Advanced"] = "Avanzato";
						it ["Expert"] = "Esperto";
						it ["Challenge"] = "Sfida";
						it ["Impossible"] = "Impossibile";
						it ["Custom"] = "Personalizzato";

						return it [index];
					} else {
						en = new Dictionary<string, string> ();

						en ["MOD_NAME"] = "Difficulty Tuning Mod";
						en ["MOD_DESCRIPTION"] = "Variety of difficulty levels. No changes in the gameplay.";

						en ["DTM_OPTIONS"] = "Difficulty Tuning Mod Options";
						en ["DIFFICULTY_LEVEL"] = "Difficulty level";
						en ["CUSTOM_OPTIONS"] = "Custom options (effective if Custom difficulty level was selected)";
						en ["CONSTRUCTION_COST"] = "Construction cost (all except roads):";
						en ["ROAD_CONSTRUCTION_COST"] = "Road construction cost:";
						en ["MAINTENANCE_COST"] = "Maintenance cost (all except roads):";
						en ["ROAD_MAINTENANCE_COST"] = "Road maintenance cost:";
						en ["AREA_COST_MULTIPLIER"] = "Area cost multiplier:";
						en ["DEMAND_OFFSET"] = "Demand offset:  -->  formula for demand: (Demand - Offset) * multiplier";
						en ["DEMAND_MULTIPLIER"] = "Demand multiplier";
						en ["REWARD"] = "Reward (amount of money you get when a milestone is reached):";
						en ["RELOCATION_COST"] = "Service building relocation cost:";
						en ["TARGET_RESIDENTIAL"] = "Target land values for residential buildings to level up (Level2, 3, 4, 5):";
						en ["TARGET_COMMERCIAL"] = "Target land values for commercial buildings to level up (Level2, 3):";
						en ["TARGET_INDUSTRIAL"] = "Target service score for industrial buildings to level up (Level2, 3):";
						en ["TARGET_OFFICE"] = "Target service score for office buildings to level up (Level2, 3):";
						
						en ["Easy"] = "Easy";
						en ["Normal"] = "Normal";
						en ["Medium"] = "Medium";
						en ["Hard"] = "Hard";
						en ["Advanced"] = "Advanced";
						en ["Expert"] = "Expert";
						en ["Challenge"] = "Challenge";
						en ["Impossible"] = "Impossible";
						en ["Custom"] = "Custom";

						return en [index];

					}
				} catch (Exception e) {
					DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Error, "Difficulty-Tuning Language File Error " + e.ToString ());
					return "Error";
				}
			
			} else {
				if (GameLanguage == "nl") {
					return nl [index];
				}
				if (GameLanguage == "it") {
					return it [index];
				}
				if (GameLanguage == "de") {
					return de [index];
				}
				return en [index];
			}
		}
	}
}
