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
                texts["MOD_DESCRIPTION"] = "Variatie in de moeilijkheidsgraad.";

                texts["Free"] = "Free"; // To translate
                texts["Easy"] = "Gemakkelijk";
                texts["Normal"] = "Normaal";
                texts["Advanced"] = "Vergevorderd";
                texts["Hard"] = "Moeilijk";
                texts["Expert"] = "Expert";
                texts["Challenge"] = "Uitdaging";
                texts["Impossible"] = "Onmogelijk";
                texts["Custom"] = "Aangepast";

                texts["DIFFICULTY_LEVEL"] = "Moeilijkheidsgraad";
                texts["CUSTOM_OPTIONS"] = "Aangepaste instellingen";

                texts["SERVICE_BUILDINGS"] = "Dienstgebouwen";
                texts["PUBLIC_TRANSPORT"] = "Openbaar vervoer";
                texts["ROADS"] = "Roads"; // To translate
                texts["OTHERS"] = "Others"; // To translate

                texts["AREA_COST_MULTIPLIER"] = "Vermenigvuldigingsfactor voor aankoop gebieden";
                texts["INITIAL_MONEY"] = "Startkapitaal";
                texts["REWARD"] = "Beloning";

                texts["DEMAND"] = "Vraag formule: (Vraag + Impuls) * vermenigvuldigingsfactor"; // To check
                texts["DEMAND_OFFSET"] = "Impuls";
                texts["DEMAND_MULTIPLIER"] = "Vermenigvuldigingsfactor";

                texts["TAGRET_LANDVALUE"] = "Grondrichtprijzen om op te waarderen (niveau 2, 3, 4, 5)";
                texts["RESIDENTIAL"] = "Woongebouwen";
                texts["COMMERCIAL"] = "Handelsgebouwen";
                texts["TAGRET_SCORE"] = "Target service score for buildings to level up (niveau 2, 3)"; // To translate
                texts["INDUSTRIAL"] = "Industriegebouwen";
                texts["OFFICE"] = "Kantoorgebouwen";
            }
            else if (selectedLanguage == "de")
            {
                texts["MOD_NAME"] = "Schwierigkeitstuningmod";
                texts["MOD_DESCRIPTION"] = "Variation in der Schwierigkeitsgrad.";

                texts["Free"] = "Free"; // To translate
                texts["Easy"] = "Einfach";
                texts["Normal"] = "Normal";
                texts["Hard"] = "Schwer";
                texts["Advanced"] = "Fortgeschritten";
                texts["Expert"] = "Expert";
                texts["Challenge"] = "Herausforderung";
                texts["Impossible"] = "Unmöglich";
                texts["Custom"] = "Angepast";

                texts["DIFFICULTY_LEVEL"] = "Schwierigkeitsgrad";
                texts["CUSTOM_OPTIONS"] = "Angepaßte Einstellungen";

                texts["SERVICE_BUILDINGS"] = "Dienstleistungsgebäude"; // To check
                texts["PUBLIC_TRANSPORT"] = "Öffentlicher Verkehr"; // To check
                texts["ROADS"] = "Straßen"; // To check
                texts["OTHERS"] = "Others"; // To translate

                texts["AREA_COST_MULTIPLIER"] = "Multiplikator für Ankauf Gebiete";
                texts["INITIAL_MONEY"] = "Anfangskapital"; // To check
                texts["REWARD"] = "Belohnung";

                texts["DEMAND"] = "Frage Formel: (Frage + Impuls) * Multiplikator"; // To check
                texts["DEMAND_OFFSET"] = "Frage-impuls";
                texts["DEMAND_MULTIPLIER"] = "Fragemultiplikationsfaktor";

                texts["TAGRET_LANDVALUE"] = "Bodenrichtpreise zu verbesseren (Stufe 2, 3, 4, 5)";
                texts["RESIDENTIAL"] = "Wohngebäude";
                texts["COMMERCIAL"] = "Gewerbgebäude";
                texts["TAGRET_SCORE"] = "Target service score for buildings to level up (Stufe 2, 3)"; // To translate
                texts["INDUSTRIAL"] = "Industriegebäude";
                texts["OFFICE"] = "Bürogebäude";
            }
            else if (selectedLanguage == "it")
            {
                texts["MOD_NAME"] = "Mod Sintonia di Difficultà";
                texts["MOD_DESCRIPTION"] = "Varietà di livelli di difficoltà.";

                texts["Free"] = "Free"; // To translate
                texts["Easy"] = "Facile";
                texts["Normal"] = "Normale";
                texts["Advanced"] = "Avanzato";
                texts["Hard"] = "Difficile";
                texts["Expert"] = "Esperto";
                texts["Challenge"] = "Sfida";
                texts["Impossible"] = "Impossibile";
                texts["Custom"] = "Personalizzato";

                texts["DIFFICULTY_LEVEL"] = "Livello di difficoltà";
                texts["CUSTOM_OPTIONS"] = "Opzioni personalizzate";

                texts["SERVICE_BUILDINGS"] = "Edifici di servizio"; // To check
                texts["PUBLIC_TRANSPORT"] = "Trasporto pubblico";
                texts["ROADS"] = "Strade";
                texts["OTHERS"] = "Others"; // To translate

                texts["AREA_COST_MULTIPLIER"] = "Moltiplicatore costi di aree";
                texts["INITIAL_MONEY"] = "Capitale iniziale";
                texts["REWARD"] = "Ricompensa";

                texts["DEMAND"] = "Domanda formula: (Domanda + Impulso) * Moltiplicatore";
                texts["DEMAND_OFFSET"] = "Impulso di domanda";
                texts["DEMAND_MULTIPLIER"] = "Moltiplicatore di domanda";

                texts["TAGRET_LANDVALUE"] = "Obiettivo valore del terreno per edifici a salire livello (Livello 2, 3, 4, 5)"; // To check
                texts["RESIDENTIAL"] = "Residenziale";
                texts["COMMERCIAL"] = "Commerciale";
                texts["TAGRET_SCORE"] = "Target service score for buildings to level up (Livello 2, 3)"; // To translate
                texts["INDUSTRIAL"] = "Industriale";
                texts["OFFICE"] = "Uffuci";
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

                texts["TAGRET_LANDVALUE"] = "Valores-alvo do custo da terra para edifícios a subir de nível (Nível 2, 3, 4, 5)"; // To check
                texts["RESIDENTIAL"] = "Residenciais";
                texts["COMMERCIAL"] = "Comerciais";
                texts["TAGRET_SCORE"] = "Target service score for buildings to level up (Nível 2, 3)"; // To translate
                texts["INDUSTRIAL"] = "Industriais";
                texts["OFFICE"] = "Escritórios";
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
                texts["PUBLIC_TRANSPORT"] = "Общ. транспорт";
                texts["ROADS"] = "Дороги";
                texts["OTHERS"] = "Остальное";

                texts["AREA_COST_MULTIPLIER"] = "Коэффициент покупки области";
                texts["INITIAL_MONEY"] = "Начальный капитал";
                texts["REWARD"] = "Награды";

                texts["DEMAND"] = "Формула потребности: (Потребность + Смещение) * Коэффициент";
                texts["DEMAND_OFFSET"] = "Смещение";
                texts["DEMAND_MULTIPLIER"] = "Коэффициент";

                texts["TAGRET_LANDVALUE"] = "Цена земли, необходимая для повышения уровня зданий (уровень 2, 3, 4, 5)";
                texts["RESIDENTIAL"] = "Жилых";
                texts["COMMERCIAL"] = "Коммерческих";
                texts["TAGRET_SCORE"] = "Сервис, необходимый для повышения уровня зданий (уровень 2, 3)";
                texts["INDUSTRIAL"] = "Промышленных";
                texts["OFFICE"] = "Офисных";
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

                texts["TAGRET_LANDVALUE"] = "Target land values for buildings to level up (Level 2, 3, 4, 5)";
                texts["RESIDENTIAL"] = "Residential";
                texts["COMMERCIAL"] = "Commercial";
                texts["TAGRET_SCORE"] = "Target service score for buildings to level up (Level 2, 3)";
                texts["INDUSTRIAL"] = "Industrial";
                texts["OFFICE"] = "Office";
            }
        }
    }
}
