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

            return texts[key];
        }

        private static void fillDictionaryWithText(string localeID)
        {
            if (selectedLanguage == "nl")
            {
                texts["MOD_NAME"] = "Moeilijkheidstuningmod";
                texts["MOD_DESCRIPTION"] = "Variatie in de moeilijkheidsgraad. Geen wijzigingen aan het spelverloop.";

                texts["DTM_OPTIONS"] = "Instellingen van Moeilijkheidstuningsmod";
                texts["DIFFICULTY_LEVEL"] = "Moeilijkheidsgraad";
                texts["CUSTOM_OPTIONS"] = "Aangepaste instellingen (enkel gebruikt indien aangepaste moeilijkheidsgraad gekozen)";
                texts["CONSTRUCTION_COST"] = "Bouwkosten (van alles behalve wegen):";
                texts["ROAD_CONSTRUCTION_COST"] = "Wegenbouwkkosten:";
                texts["MAINTENANCE_COST"] = "Onderhoudskosten (van alles behalve wegen):";
                texts["ROAD_MAINTENANCE_COST"] = "Wegonderhoudskosten:";
                texts["AREA_COST_MULTIPLIER"] = "Vermenigvuldigingsfactor voor aankoop gebieden:";
                texts["DEMAND_OFFSET"] = "Vraagimpuls:  -->  formule voor vraag: (Vraag + Impuls) * vermenigvuldigingsfactor";
                texts["DEMAND_MULTIPLIER"] = "Vraagvermenigvuldigingsfactor";
                texts["REWARD"] = "Beloning (hoeveelheid geld die je ontvangt indien een mijlpaal berijkt wordt):";
                texts["RELOCATION_COST"] = "Verhuizingskosten van nutsgebouwen:";
                texts["TARGET_RESIDENTIAL"] = "Grondrichtprijzen voor woongebouwen om op te waarderen (niveau 2, 3, 4, 5):";
                texts["TARGET_COMMERCIAL"] = "Grondrichtprijzen voor handelsgebouwen om op te waarderen (niveau 2, 3):";
                texts["TARGET_INDUSTRIAL"] = "Grondrichtprijzen voor industriegebouwen om op te waarderen (niveau 2, 3):";
                texts["TARGET_OFFICE"] = "Grondrichtprijzen voor kantoorgebouwen om op te waarderen (niveau 2, 3):";

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

                texts["DTM_OPTIONS"] = "Einstellungen Schwierigkeitsgradtuningsmod";
                texts["DIFFICULTY_LEVEL"] = "Schwierigkeitsgrad";
                texts["CUSTOM_OPTIONS"] = "Angepaßte Einstellungen (nur verwendet wenn angepaßte Schwierigkeitsgrad gewählt)";
                texts["CONSTRUCTION_COST"] = "Baukosten (alles außer Straßen):";
                texts["ROAD_CONSTRUCTION_COST"] = "Straßenbau-Kosten:";
                texts["MAINTENANCE_COST"] = "Unterhaltskosten (alles außer Straßen):";
                texts["ROAD_MAINTENANCE_COST"] = "Straßenunterhaltskosten:";
                texts["AREA_COST_MULTIPLIER"] = "Multiplikator für Ankauf Gebiete:";
                texts["DEMAND_OFFSET"] = "Frage-impuls:  -->  Formel für Frage: (Frage + Impuls) * Multiplikator";
                texts["DEMAND_MULTIPLIER"] = "Fragemultiplikationsfaktor";
                texts["REWARD"] = "Belohnung (Betrag, den du erhaltet, wenn einen Meilenstein erreicht wird):";
                texts["RELOCATION_COST"] = "Umzugskosten von Nutzgebäude:";
                texts["TARGET_RESIDENTIAL"] = "Bodenrichtpreise für Wohngebäude zu verbesseren (Stufe 2, 3, 4, 5):";
                texts["TARGET_COMMERCIAL"] = "Bodenrichtpreise für Gewerbgebäude zu verbesseren (Stufe 2, 3):";
                texts["TARGET_INDUSTRIAL"] = "Bodenrichtpreise für Industriegebäude zu verbesseren (Stufe 2, 3):";
                texts["TARGET_OFFICE"] = "Bodenrichtpreise für Bürogebäude zu verbesseren (Stufe 2, 3):";

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

                texts["DTM_OPTIONS"] = "Opzioni Mod Sintonia di Difficultà";
                texts["DIFFICULTY_LEVEL"] = "Livello di difficoltà";
                texts["CUSTOM_OPTIONS"] = "Opzioni personalizzate (efficace se è stato selezionato livello difficoltà personalizzate)";
                texts["CONSTRUCTION_COST"] = "Costo di costruzione (tutto tranne strade):";
                texts["ROAD_CONSTRUCTION_COST"] = "Costo di costruzione strade:";
                texts["MAINTENANCE_COST"] = "Costo di manutenzione (tutti tranne strade):";
                texts["ROAD_MAINTENANCE_COST"] = "Costo di manutenzione strade:";
                texts["AREA_COST_MULTIPLIER"] = "Moltiplicatore costi di aree:";
                texts["DEMAND_OFFSET"] = "Impulso di domanda:  -->  formula per domanda: (Domanda + Impulso) * moltiplicatore";
                texts["DEMAND_MULTIPLIER"] = "Moltiplicatore di domanda";
                texts["REWARD"] = "Ricompensa (fundi che si ottiene quando si raggiunge una pietra miliare):";
                texts["RELOCATION_COST"] = "Costi trasferimenti dei edifici di utilità:";
                texts["TARGET_RESIDENTIAL"] = "Obiettivo valore del terreno per edifici residenziale a salire livello (Livello 2, 3, 4, 5):";
                texts["TARGET_COMMERCIAL"] = "Obiettivo valore del terreno per edifici commerciale a salire livello (Livello 2, 3):";
                texts["TARGET_INDUSTRIAL"] = "Obiettivo valore del terreno per edifici industriale a salire livello (Livello 2, 3):";
                texts["TARGET_OFFICE"] = "Obiettivo valore del terreno per edifici uffuci a salire livello (Livello 2, 3):";

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
                texts["MOD_DESCRIPTION"] = "A variedade de níveis de dificuldade. Não ocorreram alterações na jogabilidade.";

                texts["DTM_OPTIONS"] = "Opções a Mod Ajuste de Dificuldade";
                texts["DIFFICULTY_LEVEL"] = "Nível de dificuldade";
                texts["CUSTOM_OPTIONS"] = "Opções personalizadas (eficaz se o nível de dificuldade personalizado foi selecionado)";
                texts["CONSTRUCTION_COST"] = "Custo de construção (todos exceto estradas):";
                texts["ROAD_CONSTRUCTION_COST"] = "Custo de construção de estradas:";
                texts["MAINTENANCE_COST"] = "Custo de manutenção (todos exceto estradas):";
                texts["ROAD_MAINTENANCE_COST"] = "Custo de manutenção de estradas:";
                texts["AREA_COST_MULTIPLIER"] = "Multiplicador de custos da área:";
                texts["DEMAND_OFFSET"] = "Compensação de demanda: -> fórmula para a demanda: (Demanda + Compensação) * multiplicador";
                texts["DEMAND_MULTIPLIER"] = "Multiplicador de demanda";
                texts["REWARD"] = "Recompensa (valor de dinheiro se obtém quando um marco é atingido):";
                texts["RELOCATION_COST"] = "Custo de deslocalizações de edifícios de serviços:";
                texts["TARGET_RESIDENTIAL"] = "Valores-alvo do custo da terra para edifícios residenciais a subir de nível (Nível 2, 3, 4, 5):";
                texts["TARGET_COMMERCIAL"] = "Valores-alvo do custo da terra para edifícios comerciais a subir de nível (Nível 2, 3):";
                texts["TARGET_INDUSTRIAL"] = "Valores-alvo do custo da terra para edifícios industriais a subir de nível (Nível 2, 3):";
                texts["TARGET_OFFICE"] = "Valores-alvo do custo da terra para edifícios de escritórios a subir de nível (Nível 2, 3):";

                texts["Easy"] = "Fácil";
                texts["Normal"] = "Normal";
                texts["Medium"] = "Médio";
                texts["Hard"] = "Difício";
                texts["Advanced"] = "Advançado";
                texts["Expert"] = "Perito";
                texts["Challenge"] = "Desafio";
                texts["Impossible"] = "Imposivel";
                texts["Custom"] = "Personalizado";
            }
            else if (selectedLanguage == "ru")
            {
                texts["MOD_NAME"] = "Настройка сложности";
                texts["MOD_DESCRIPTION"] = "Различные уровни сложности (без изменения игровой механики).";

                texts["DTM_OPTIONS"] = "Настройка уровня сложности";
                texts["DIFFICULTY_LEVEL"] = "Уровень сложности";
                texts["CUSTOM_OPTIONS"] = "Пользовательские настройки (работают только если выбран Пользовательский)";
                texts["CONSTRUCTION_COST"] = "Стоимость построек (кроме дорог):";
                texts["ROAD_CONSTRUCTION_COST"] = "Стоимость прокладки дорог:";
                texts["MAINTENANCE_COST"] = "Содержание построек (кроме дорог):";
                texts["ROAD_MAINTENANCE_COST"] = "Содержание дорог:";
                texts["AREA_COST_MULTIPLIER"] = "Коэффициент покупки области:";
                texts["DEMAND_OFFSET"] = "Смещение потребности:  -->  формула: (Потребность + Смещение) * Коэффициент";
                texts["DEMAND_MULTIPLIER"] = "Коэффициент потребности:";
                texts["REWARD"] = "Награда (сумма, которую дают игроку после достижения некоторых этапов):";
                texts["RELOCATION_COST"] = "Стоимость перемещения зданий:";
                texts["TARGET_RESIDENTIAL"] = "Цена земли, необходимая для повышения уровня жилых зданий (уровень 2, 3, 4, 5):";
                texts["TARGET_COMMERCIAL"] = "Цена земли, необходимая для повышения уровня коммерческих зданий (уровень 2, 3):";
                texts["TARGET_INDUSTRIAL"] = "Сервис, необходимый для повышения уровня промышленных зданий (уровень 2, 3):";
                texts["TARGET_OFFICE"] = "Сервис, необходимый для повышения уровня офисных зданий (уровень 2, 3):";

                texts["Easy"] = "Легкий";
                texts["Normal"] = "Обычный";
                texts["Medium"] = "Средний";
                texts["Hard"] = "Сложный";
                texts["Advanced"] = "Продвинутый";
                texts["Expert"] = "Эксперт";
                texts["Challenge"] = "Челендж";
                texts["Impossible"] = "Невозможный";
                texts["Custom"] = "Пользовательский";
            }
            else
            {
                texts["MOD_NAME"] = "Difficulty Tuning Mod";
                texts["MOD_DESCRIPTION"] = "Variety of difficulty levels. No changes in the gameplay.";

                texts["DTM_OPTIONS"] = "Difficulty Tuning Mod Options";
                texts["DIFFICULTY_LEVEL"] = "Difficulty level";
                texts["CUSTOM_OPTIONS"] = "Custom options (effective if Custom difficulty level was selected)";
                texts["CONSTRUCTION_COST"] = "Construction cost (all except roads):";
                texts["ROAD_CONSTRUCTION_COST"] = "Road construction cost:";
                texts["MAINTENANCE_COST"] = "Maintenance cost (all except roads):";
                texts["ROAD_MAINTENANCE_COST"] = "Road maintenance cost:";
                texts["AREA_COST_MULTIPLIER"] = "Area cost multiplier:";
                texts["DEMAND_OFFSET"] = "Demand offset:  -->  formula for demand: (Demand + Offset) * multiplier";
                texts["DEMAND_MULTIPLIER"] = "Demand multiplier";
                texts["REWARD"] = "Reward (amount of money you get when a milestone is reached):";
                texts["RELOCATION_COST"] = "Service building relocation cost:";
                texts["TARGET_RESIDENTIAL"] = "Target land values for residential buildings to level up (Level2, 3, 4, 5):";
                texts["TARGET_COMMERCIAL"] = "Target land values for commercial buildings to level up (Level2, 3):";
                texts["TARGET_INDUSTRIAL"] = "Target service score for industrial buildings to level up (Level2, 3):";
                texts["TARGET_OFFICE"] = "Target service score for office buildings to level up (Level2, 3):";

                texts["Easy"] = "Easy";
                texts["Normal"] = "Normal";
                texts["Medium"] = "Medium";
                texts["Hard"] = "Hard";
                texts["Advanced"] = "Advanced";
                texts["Expert"] = "Expert";
                texts["Challenge"] = "Challenge";
                texts["Impossible"] = "Impossible";
                texts["Custom"] = "Custom";
            }
        }
    }
}
