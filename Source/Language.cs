using System.Collections.Generic;
//using ColossalFramework.Plugins;
using ColossalFramework.Globalization;

namespace DifficultyTuningMod
{
    public static class DTMLang
    {
        private static string selectedLanguage;
        private static Dictionary<string, string> texts = new Dictionary<string, string>();

        public static string Text(string key)
        {
            string currentLanguage = LocaleManager.instance.language;

            if (selectedLanguage == null || selectedLanguage != currentLanguage)
            {
                selectedLanguage = currentLanguage;
                fillDictionaryWithText(selectedLanguage);
                //DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "localeID: " + selectedLanguage);
            }

            if (texts.ContainsKey(key))
            {
                return texts[key];
            }

            return key;
        }

        private static void fillDictionaryWithText(string localeID)
        {
            if (selectedLanguage == "nl")
            {
                texts["MOD_NAME"] = "Moeilijkheidstuningmod";
                texts["MOD_DESCRIPTION"] = "Variatie in de moeilijkheidsgraad. Geen wijzigingen aan het spelverloop.";

                //texts["DTM_OPTIONS"] = "Instellingen van Moeilijkheidstuningsmod";
                texts["DIFFICULTY_LEVEL"] = "Moeilijkheidsgraad";
                //texts["CUSTOM_OPTIONS"] = "Aangepaste instellingen (enkel gebruikt indien aangepaste moeilijkheidsgraad gekozen)";
                texts["CUSTOM_OPTIONS"] = "Aangepaste instellingen";
                texts["CONSTRUCTION_COST"] = "Bouwkosten (van alles behalve wegen)";
                texts["CONSTRUCTION_COST_ROADS"] = "Wegenbouwkkosten";
                texts["MAINTENANCE_COST"] = "Onderhoudskosten (van alles behalve wegen)";
                texts["ROAD_MAINTENANCE_COST"] = "Wegonderhoudskosten";
                texts["AREA_COST_MULTIPLIER"] = "Vermenigvuldigingsfactor voor aankoop gebieden";
                texts["DEMAND_OFFSET"] = "Vraagimpuls";
                texts["DEMAND_MULTIPLIER"] = "Vraagvermenigvuldigingsfactor >>> formule: (Vraag + Impuls) * vermenigvuldigingsfactor";
                texts["REWARD"] = "Beloning (hoeveelheid geld die je ontvangt indien een mijlpaal berijkt wordt)";
                texts["RELOCATION_COST"] = "Verhuizingskosten van nutsgebouwen";
                texts["TARGET_RESIDENTIAL"] = "Grondrichtprijzen voor woongebouwen om op te waarderen (niveau 2, 3, 4, 5)";
                texts["TARGET_COMMERCIAL"] = "Grondrichtprijzen voor handelsgebouwen om op te waarderen (niveau 2, 3)";
                texts["TARGET_INDUSTRIAL"] = "Grondrichtprijzen voor industriegebouwen om op te waarderen (niveau 2, 3)";
                texts["TARGET_OFFICE"] = "Grondrichtprijzen voor kantoorgebouwen om op te waarderen (niveau 2, 3)";

                texts["Easy"] = "Gemakkelijk";
                texts["Normal"] = "Normaal";
                texts["Medium"] = "Gemiddeld";
                texts["Hard"] = "Moeilijk";
                texts["Advanced"] = "Vergevorderd";
                texts["Expert"] = "Expert";
                texts["Challenge"] = "Uitdaging";
                texts["Impossible"] = "Onmogelijk";
                texts["Custom"] = "Aangepast";
            }
            else if (selectedLanguage == "de")
            {
                texts["MOD_NAME"] = "Schwierigkeitstuningmod";
                texts["MOD_DESCRIPTION"] = "Variation in der Schwierigkeitsgrad. Keine Änderungen am Spielverlauf.";

                //texts["DTM_OPTIONS"] = "Einstellungen Schwierigkeitsgradtuningsmod";
                texts["DIFFICULTY_LEVEL"] = "Schwierigkeitsgrad";
                //texts["CUSTOM_OPTIONS"] = "Angepaßte Einstellungen (nur verwendet wenn angepaßte Schwierigkeitsgrad gewählt)";
                texts["CUSTOM_OPTIONS"] = "Angepaßte Einstellungen";
                texts["CONSTRUCTION_COST"] = "Baukosten (alles außer Straßen)";
                texts["CONSTRUCTION_COST_ROADS"] = "Straßenbau-Kosten";
                texts["MAINTENANCE_COST"] = "Unterhaltskosten (alles außer Straßen)";
                texts["ROAD_MAINTENANCE_COST"] = "Straßenunterhaltskosten";
                texts["AREA_COST_MULTIPLIER"] = "Multiplikator für Ankauf Gebiete";
                texts["DEMAND_OFFSET"] = "Frage-impuls";
                texts["DEMAND_MULTIPLIER"] = "Fragemultiplikationsfaktor >>> Formel: (Frage + Impuls) * Multiplikator";
                texts["REWARD"] = "Belohnung (Betrag, den du erhaltet, wenn einen Meilenstein erreicht wird)";
                texts["RELOCATION_COST"] = "Umzugskosten von Nutzgebäude";
                texts["TARGET_RESIDENTIAL"] = "Bodenrichtpreise für Wohngebäude zu verbesseren (Stufe 2, 3, 4, 5)";
                texts["TARGET_COMMERCIAL"] = "Bodenrichtpreise für Gewerbgebäude zu verbesseren (Stufe 2, 3)";
                texts["TARGET_INDUSTRIAL"] = "Bodenrichtpreise für Industriegebäude zu verbesseren (Stufe 2, 3)";
                texts["TARGET_OFFICE"] = "Bodenrichtpreise für Bürogebäude zu verbesseren (Stufe 2, 3)";

                texts["Easy"] = "Einfach";
                texts["Normal"] = "Normal";
                texts["Medium"] = "Gemittelt";
                texts["Hard"] = "Schwer";
                texts["Advanced"] = "Fortgeschritten";
                texts["Expert"] = "Expert";
                texts["Challenge"] = "Herausforderung";
                texts["Impossible"] = "Unmöglich";
                texts["Custom"] = "Angepast";
            }
            else if (selectedLanguage == "it")
            {
                texts["MOD_NAME"] = "Mod Sintonia di Difficultà";
                texts["MOD_DESCRIPTION"] = "Varietà di livelli di difficoltà. Nessuni modificazioni nel gameplay.";

                //texts["DTM_OPTIONS"] = "Opzioni Mod Sintonia di Difficultà";
                texts["DIFFICULTY_LEVEL"] = "Livello di difficoltà";
                //texts["CUSTOM_OPTIONS"] = "Opzioni personalizzate (efficace se è stato selezionato livello difficoltà personalizzate)";
                texts["CUSTOM_OPTIONS"] = "Opzioni personalizzate";
                texts["CONSTRUCTION_COST"] = "Costo di costruzione (tutto tranne strade)";
                texts["CONSTRUCTION_COST_ROADS"] = "Costo di costruzione strade";
                texts["MAINTENANCE_COST"] = "Costo di manutenzione (tutti tranne strade)";
                texts["ROAD_MAINTENANCE_COST"] = "Costo di manutenzione strade";
                texts["AREA_COST_MULTIPLIER"] = "Moltiplicatore costi di aree";
                texts["DEMAND_OFFSET"] = "Impulso di domanda";
                texts["DEMAND_MULTIPLIER"] = "Moltiplicatore di domanda >>> formula: (Domanda + Impulso) * moltiplicatore";
                texts["REWARD"] = "Ricompensa (fundi che si ottiene quando si raggiunge una pietra miliare)";
                texts["RELOCATION_COST"] = "Costi trasferimenti dei edifici di utilità";
                texts["TARGET_RESIDENTIAL"] = "Obiettivo valore del terreno per edifici residenziale a salire livello (Livello 2, 3, 4, 5)";
                texts["TARGET_COMMERCIAL"] = "Obiettivo valore del terreno per edifici commerciale a salire livello (Livello 2, 3)";
                texts["TARGET_INDUSTRIAL"] = "Obiettivo valore del terreno per edifici industriale a salire livello (Livello 2, 3)";
                texts["TARGET_OFFICE"] = "Obiettivo valore del terreno per edifici uffuci a salire livello (Livello 2, 3)";

                texts["Easy"] = "Facile";
                texts["Normal"] = "Normale";
                texts["Medium"] = "Media";
                texts["Hard"] = "Difficile";
                texts["Advanced"] = "Avanzato";
                texts["Expert"] = "Esperto";
                texts["Challenge"] = "Sfida";
                texts["Impossible"] = "Impossibile";
                texts["Custom"] = "Personalizzato";
            }
            else if (selectedLanguage == "pt")
            {
                texts["MOD_NAME"] = "Mod Ajuste de Dificuldade";
                texts["MOD_DESCRIPTION"] = "A variedade de níveis de dificuldade.";

                texts["Free"] = "Free"; // To translate
                texts["Easy"] = "Fácil";
                texts["Normal"] = "Normal";
                texts["Advanced"] = "Advançado";
                texts["Hard"] = "Difício";
                texts["Expert"] = "Perito";
                texts["Challenge"] = "Desafio";
                texts["Impossible"] = "Imposivel";
                texts["Custom"] = "Personalizado";

                texts["DIFFICULTY_LEVEL"] = "Nível de dificuldade";
                texts["CUSTOM_OPTIONS"] = "Opções personalizadas";

                texts["SERVICE_BUILDINGS"] = "Edifícios de serviços";
                texts["PUBLIC_TRANSPORT"] = "Transporte público";
                texts["ROADS"] = "Estradas";
                texts["OTHERS"] = "Others"; // To translate

                texts["AREA_COST_MULTIPLIER"] = "Multiplicador de custos da área";
                texts["INITIAL_MONEY"] = "Capital inicial";
                texts["REWARD"] = "Recompensa";

                texts["DEMAND"] = "Demanda fórmula: (Demanda + Compensação) * multiplicador";
                texts["DEMAND_OFFSET"] = "Compensação de demanda";
                texts["DEMAND_MULTIPLIER"] = "Multiplicador de demanda";

                texts["RESIDENTIAL_LEVELUP"] = "Valores-alvo do custo da terra para edifícios residenciais a subir de nível (Nível 2, 3, 4, 5)";
                texts["COMMERCIAL_LEVELUP"] = "Valores-alvo do custo da terra para edifícios comerciais a subir de nível (Nível 2, 3)";
                texts["INDUSTRIAL_LEVELUP"] = "Valores-alvo do custo da terra para edifícios industriais a subir de nível (Nível 2, 3)";
                texts["OFFICE_LEVELUP"] = "Valores-alvo do custo da terra para edifícios de escritórios a subir de nível (Nível 2, 3)";
            }
            else if (selectedLanguage == "ru")
            {
                texts["MOD_NAME"] = "Настройка сложности";
                texts["MOD_DESCRIPTION"] = "Различные уровни сложности.";

                texts["Free"] = "Бесплатный";
                texts["Easy"] = "Легкий";
                texts["Normal"] = "Обычный";
                texts["Advanced"] = "Продвинутый";
                texts["Hard"] = "Сложный";
                texts["Expert"] = "Эксперт";
                texts["Challenge"] = "Челендж";
                texts["Impossible"] = "Невозможный";
                texts["Custom"] = "Пользовательский";

                texts["DIFFICULTY_LEVEL"] = "Уровень сложности";
                texts["CUSTOM_OPTIONS"] = "Пользовательские настройки";

                texts["SERVICE_BUILDINGS"] = "Постройки";
                texts["PUBLIC_TRANSPORT"] = "Общественный транспорт";
                texts["ROADS"] = "Дороги";
                texts["OTHERS"] = "Остальное";

                texts["AREA_COST_MULTIPLIER"] = "Коэффициент покупки области";
                texts["INITIAL_MONEY"] = "Начальный капитал";
                texts["REWARD"] = "Награда (сумма, которую дают игроку после достижения некоторых этапов)";

                texts["DEMAND"] = "Формула потребности: (Потребность + Смещение) * Коэффициент";
                texts["DEMAND_OFFSET"] = "Смещение";
                texts["DEMAND_MULTIPLIER"] = "Коэффициент";

                texts["RESIDENTIAL_LEVELUP"] = "Цена земли, необходимая для повышения уровня жилых зданий (уровень 2, 3, 4, 5)";
                texts["COMMERCIAL_LEVELUP"] = "Цена земли, необходимая для повышения уровня коммерческих зданий (уровень 2, 3)";
                texts["INDUSTRIAL_LEVELUP"] = "Сервис, необходимый для повышения уровня промышленных зданий (уровень 2, 3)";
                texts["OFFICE_LEVELUP"] = "Сервис, необходимый для повышения уровня офисных зданий (уровень 2, 3)";
            }
            else
            {
                texts["MOD_NAME"] = "Difficulty Tuning Mod";
                texts["MOD_DESCRIPTION"] = "Variety of difficulty levels.";

                texts["Free"] = "Free";
                texts["Easy"] = "Easy";
                texts["Normal"] = "Normal";
                texts["Advanced"] = "Advanced";
                texts["Hard"] = "Hard";
                texts["Expert"] = "Expert";
                texts["Challenge"] = "Challenge";
                texts["Impossible"] = "Impossible";
                texts["Custom"] = "Custom";

                texts["DIFFICULTY_LEVEL"] = "Difficulty level";
                texts["CUSTOM_OPTIONS"] = "Custom options";

                texts["SERVICE_BUILDINGS"] = "Service buildings";
                texts["PUBLIC_TRANSPORT"] = "Public transport";
                texts["ROADS"] = "Roads";
                texts["OTHERS"] = "Others";

                texts["AREA_COST_MULTIPLIER"] = "Area cost multiplier";
                texts["INITIAL_MONEY"] = "Initial capital";
                texts["REWARD"] = "Reward amount"; // amount of money you get when a milestone is reached

                texts["DEMAND"] = "Demand formula: (Demand + Offset) * multiplier";
                texts["DEMAND_OFFSET"] = "Demand offset";
                texts["DEMAND_MULTIPLIER"] = "Demand multiplier";

                texts["RESIDENTIAL_LEVELUP"] = "Target land values for residential buildings to level up (Level2, 3, 4, 5)";
                texts["COMMERCIAL_LEVELUP"] = "Target land values for commercial buildings to level up (Level2, 3)";
                texts["INDUSTRIAL_LEVELUP"] = "Target service score for industrial buildings to level up (Level2, 3)";
                texts["OFFICE_LEVELUP"] = "Target service score for office buildings to level up (Level2, 3)";
            }
        }
    }
}
