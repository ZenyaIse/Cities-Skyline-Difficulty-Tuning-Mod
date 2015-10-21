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

                texts["Easy"] = "1. Gemakkelijk";
                texts["Normal"] = "2. Normaal";
                texts["Advanced"] = "3. Vergevorderd";
                texts["Hard"] = "4. Moeilijk";
                texts["Expert"] = "5. Expert";
                texts["Challenge"] = "6. Uitdaging";
                texts["Impossible"] = "7. Onmogelijk";
                texts["Custom"] = "-- Aangepast --";
                texts["Free"] = "Speciaal: Gratis";
                texts["FiveHundred"] = "Speciaal: ₡500,000 bij aanvang";
                texts["Demand111"] = "Speciaal: Vraag 100%";
                texts["PublicTransport"] = "Speciaal: Gratis openbaar vervoer";
                texts["LowCity"] = "Speciaal: Laagbouwstad"; 
                texts["HardAndFast"] = "Speciaal: Moeilijk en snel";

                texts["DIFFICULTY_LEVEL"] = "Moeilijkheidsgraad";
                texts["CUSTOM_OPTIONS"] = "Aangepaste instellingen";

                texts["SERVICE_BUILDINGS"] = "Dienstgebouwen";
                texts["PUBLIC_TRANSPORT"] = "Openbaar vervoer";
                texts["ROADS"] = "Wegen";
                texts["OTHERS"] = "Andere";

                texts["AREA_COST_MULTIPLIER"] = "Vermenigvuldigingsfactor voor aankoop gebieden";
                texts["INITIAL_MONEY"] = "Startkapitaal";
                texts["REWARD"] = "Beloning";

                texts["DEMAND"] = "Vraagformule: (Vraag + Impuls) * vermenigvuldigingsfactor";
                texts["DEMAND_OFFSET"] = "Impuls";
                texts["DEMAND_MULTIPLIER"] = "Vermenigvuldigingsfactor";

                texts["TAGRET_LANDVALUE"] = "Grondrichtprijzen om op te waarderen (niveau 2, 3, 4, 5)";
                texts["RESIDENTIAL"] = "Woongebouwen";
                texts["COMMERCIAL"] = "Handelsgebouwen";
                texts["TAGRET_SCORE"] = "Dienstenscoredoel voor gebouwen om op te waarderen (niveau 2, 3)";
                texts["INDUSTRIAL"] = "Industriegebouwen";
                texts["OFFICE"] = "Kantoorgebouwen"; 

                texts["POPULATION_TARGET_MULTIPLIER"] = "Population required to unlock milestones"; // To translate
            }
            else if (selectedLanguage == "de")
            {
                texts["MOD_NAME"] = "Schwierigkeitstuningmod";
                texts["MOD_DESCRIPTION"] = "Variation in der Schwierigkeitsgrad.";

                texts["Easy"] = "1. Einfach";
                texts["Normal"] = "2. Normal";
                texts["Hard"] = "3. Schwer";
                texts["Advanced"] = "4. Fortgeschritten";
                texts["Expert"] = "5. Expert";
                texts["Challenge"] = "6. Herausforderung";
                texts["Impossible"] = "7. Unmöglich";
                texts["Custom"] = "-- Angepast --";
                texts["Free"] = "Speziell: Kostenlos";
                texts["FiveHundred"] = "Speziell: ₡500,000 am Anfang";
                texts["Demand111"] = "Speziell: Frage 100%";
                texts["PublicTransport"] = "Speziell: Kostenloser öffentlichen Verkehrsmittel";
                texts["LowCity"] = "Speziell: Flachbaustadt";
                texts["HardAndFast"] = "Special: Schwer und schnell";

                texts["DIFFICULTY_LEVEL"] = "Schwierigkeitsgrad";
                texts["CUSTOM_OPTIONS"] = "Angepaßte Einstellungen";

                /* My dictionary says "Stadtwerke", which I think would be better,
                  but the game itself uses Dienstleistungsgebaude, so lets continue to use that: */
                texts["SERVICE_BUILDINGS"] = "Dienstleistungsgebäude"; 
                texts["PUBLIC_TRANSPORT"] = "Öffentlichen Verkehrsmittel";
                texts["ROADS"] = "Straßen";
                texts["OTHERS"] = "Sonstige";

                texts["AREA_COST_MULTIPLIER"] = "Multiplikator für Ankauf Gebiete";
                texts["INITIAL_MONEY"] = "Anfangskapital";
                texts["REWARD"] = "Belohnung";

                texts["DEMAND"] = "Frage-formel: (Frage + Impuls) * Multiplikator"; 
                texts["DEMAND_OFFSET"] = "Impuls";
                texts["DEMAND_MULTIPLIER"] = "Multiplikator";

                texts["TAGRET_LANDVALUE"] = "Bodenrichtpreise für Gebaude zu verbesseren (Stufe 2, 3, 4, 5)";
                texts["RESIDENTIAL"] = "Wohngebäude";
                texts["COMMERCIAL"] = "Gewerbgebäude";
                texts["TAGRET_SCORE"] = "Dienstergebnisziel für Gebaude zu verbesseren (Stufe 2, 3)";
                texts["INDUSTRIAL"] = "Industriegebäude";
                texts["OFFICE"] = "Bürogebäude";

                texts["POPULATION_TARGET_MULTIPLIER"] = "Population required to unlock milestones"; // To translate
            }
            else if (selectedLanguage == "it")
            {
                texts["MOD_NAME"] = "Mod Sintonia di Difficultà";
                texts["MOD_DESCRIPTION"] = "Varietà di livelli di difficoltà.";

                texts["Easy"] = "1. Facile";
                texts["Normal"] = "2. Normale";
                texts["Advanced"] = "3. Avanzato";
                texts["Hard"] = "4. Difficile";
                texts["Expert"] = "5. Esperto";
                texts["Challenge"] = "6. Sfida";
                texts["Impossible"] = "7. Impossibile";
                texts["Custom"] = "-- Personalizzato --";
                texts["Free"] = "Speciale: Gratis";
                texts["FiveHundred"] = "Speciale: ₡500,000 all'inizio";
                texts["Demand111"] = "Speciale: Domanda 100%";
                texts["PublicTransport"] = "Speciale: Trasporto pubblico gratis";
                texts["LowCity"] = "Speciale: Citá edificio basso";
                texts["HardAndFast"] = "Speciale: Difficile e veloce";

                texts["DIFFICULTY_LEVEL"] = "Livello di difficoltà";
                texts["CUSTOM_OPTIONS"] = "Opzioni personalizzate";

                texts["SERVICE_BUILDINGS"] = "Edifici di utilità";
                texts["PUBLIC_TRANSPORT"] = "Trasporto pubblico";
                texts["ROADS"] = "Strade";
                texts["OTHERS"] = "Altri";

                texts["AREA_COST_MULTIPLIER"] = "Moltiplicatore costi di aree";
                texts["INITIAL_MONEY"] = "Capitale iniziale";
                texts["REWARD"] = "Ricompensa";

                texts["DEMAND"] = "Domanda formula: (Domanda + Impulso) * Moltiplicatore";
                texts["DEMAND_OFFSET"] = "Impulso";
                texts["DEMAND_MULTIPLIER"] = "Moltiplicatore";

                texts["TAGRET_LANDVALUE"] = "Obiettivo valore del terreno per edifici a salire livello (Livello 2, 3, 4, 5)"; // To check
                texts["RESIDENTIAL"] = "Residenziale";
                texts["COMMERCIAL"] = "Commerciale";
                texts["TAGRET_SCORE"] = "Target service score for buildings to level up (Livello 2, 3)"; // To translate
                texts["INDUSTRIAL"] = "Industriale";
                texts["OFFICE"] = "Uffici";

                texts["POPULATION_TARGET_MULTIPLIER"] = "Population required to unlock milestones"; // To translate
            }
            else if (selectedLanguage == "pt")
            {
                texts["MOD_NAME"] = "Mod Ajuste de Dificuldade";
                texts["MOD_DESCRIPTION"] = "A variedade de níveis de dificuldade.";

                texts["Easy"] = "1. Fácil";
                texts["Normal"] = "2. Normal";
                texts["Advanced"] = "3. Advançado";
                texts["Hard"] = "4. Difício";
                texts["Expert"] = "5. Perito";
                texts["Challenge"] = "6. Desafio";
                texts["Impossible"] = "7. Imposivel";
                texts["Custom"] = "-- Personalizado --";
                texts["Free"] = "Special: Free"; // To translate
                texts["FiveHundred"] = "Special: ₡500,000 at start"; // To translate
                texts["Demand111"] = "Special: Demand 100%"; // To translate
                texts["PublicTransport"] = "Special: Free Public Transport"; // To translate
                texts["LowCity"] = "Special: Low city"; // To translate
                texts["HardAndFast"] = "Special: Hard and fast"; // To translate

                texts["DIFFICULTY_LEVEL"] = "Nível de dificuldade";
                texts["CUSTOM_OPTIONS"] = "Opções personalizadas";

                texts["SERVICE_BUILDINGS"] = "Edifícios de serviços";
                texts["PUBLIC_TRANSPORT"] = "Transporte público";
                texts["ROADS"] = "Estradas";
                texts["OTHERS"] = "Outros";

                texts["AREA_COST_MULTIPLIER"] = "Multiplicador de custos da área";
                texts["INITIAL_MONEY"] = "Capital inicial";
                texts["REWARD"] = "Recompensa";

                texts["DEMAND"] = "Demanda fórmula: (Demanda + Compensação) * multiplicador";
                texts["DEMAND_OFFSET"] = "Compensação";
                texts["DEMAND_MULTIPLIER"] = "Multiplicador";

                texts["TAGRET_LANDVALUE"] = "Valores-alvo do custo da terra para edifícios a subir de nível (Nível 2, 3, 4, 5)"; // To check
                texts["RESIDENTIAL"] = "Residenciais";
                texts["COMMERCIAL"] = "Comerciais";
                texts["TAGRET_SCORE"] = "Target service score for buildings to level up (Nível 2, 3)"; // To translate
                texts["INDUSTRIAL"] = "Industriais";
                texts["OFFICE"] = "Escritórios";

                texts["POPULATION_TARGET_MULTIPLIER"] = "Population required to unlock milestones"; // To translate
            }
            else if (selectedLanguage == "ru")
            {
                texts["MOD_NAME"] = "Настройка сложности";
                texts["MOD_DESCRIPTION"] = "Различные уровни сложности.";

                texts["Easy"] = "1. Легкий";
                texts["Normal"] = "2. Обычный";
                texts["Advanced"] = "3. Продвинутый";
                texts["Hard"] = "4. Сложный";
                texts["Expert"] = "5. Эксперт";
                texts["Challenge"] = "6. Челендж";
                texts["Impossible"] = "7. Невозможный";
                texts["Custom"] = "-- Пользовательский --";
                texts["Free"] = "Спец.: Бесплатный";
                texts["FiveHundred"] = "Спец.: Начало с ₡500,000";
                texts["Demand111"] = "Спец.: Потребность 100%";
                texts["PublicTransport"] = "Спец.: Общ. транспорт бесплатно";
                texts["LowCity"] = "Спец.: Большая деревня";
                texts["HardAndFast"] = "Спец.: Сложно и быстро";

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

                texts["POPULATION_TARGET_MULTIPLIER"] = "Количество населения, необходимое для достижения этапов";
            }
            else if (selectedLanguage == "ja")
            {
                texts["MOD_NAME"] = "難易度設定モード";
                texts["MOD_DESCRIPTION"] = "さまざまな難易度レベル、詳細設定。";

                texts["Easy"] = "1. 簡単";
                texts["Normal"] = "2. 普通";
                texts["Advanced"] = "3. 難しい";
                texts["Hard"] = "4. ハード";
                texts["Expert"] = "5. エキスパート";
                texts["Challenge"] = "6. 挑戦";
                texts["Impossible"] = "7. インポッシブル";
                texts["Custom"] = "-- カスタム --";
                texts["Free"] = "スペシャル：　無料";
                texts["FiveHundred"] = "スペシャル：　最初から₡500,000";
                texts["Demand111"] = "スペシャル：　100%デマンド";
                texts["PublicTransport"] = "スペシャル：　無料交通機関";
                texts["LowCity"] = "スペシャル：　低い町";
                texts["HardAndFast"] = "スペシャル：　ハードとファスト";

                texts["DIFFICULTY_LEVEL"] = "難易度";
                texts["CUSTOM_OPTIONS"] = "カスタム設定";

                texts["SERVICE_BUILDINGS"] = "公共施設";
                texts["PUBLIC_TRANSPORT"] = "交通機関";
                texts["ROADS"] = "道路";
                texts["OTHERS"] = "その他";

                texts["AREA_COST_MULTIPLIER"] = "地域購入コスト係数";
                texts["INITIAL_MONEY"] = "初期金額";
                texts["REWARD"] = "報酬の割合";

                texts["DEMAND"] = "需要。次式で計算：　（需要＋オフセット）＊係数";
                texts["DEMAND_OFFSET"] = "オフセット";
                texts["DEMAND_MULTIPLIER"] = "係数";

                texts["TAGRET_LANDVALUE"] = "建物レベルアップのための地価の目標値（レベル2,3,4,5）";
                texts["RESIDENTIAL"] = "住宅";
                texts["COMMERCIAL"] = "商業";
                texts["TAGRET_SCORE"] = "建物レベルアップのためのサービススコアの目標値（レベル2,3）";
                texts["INDUSTRIAL"] = "産業";
                texts["OFFICE"] = "オフィス";

                texts["POPULATION_TARGET_MULTIPLIER"] = "マイルストーンの目標人口の係数";
            }
            else
            {
                texts["MOD_NAME"] = "Difficulty Tuning Mod";
                texts["MOD_DESCRIPTION"] = "Variety of difficulty levels.";

                texts["Easy"] = "1. Easy";
                texts["Normal"] = "2. Normal";
                texts["Advanced"] = "3. Advanced";
                texts["Hard"] = "4. Hard";
                texts["Expert"] = "5. Expert";
                texts["Challenge"] = "6. Challenge";
                texts["Impossible"] = "7. Impossible";
                texts["Custom"] = "-- Custom --";
                texts["Free"] = "Special: Free";
                texts["FiveHundred"] = "Special: ₡500,000 at start";
                texts["Demand111"] = "Special: Demand 100%";
                texts["PublicTransport"] = "Special: Free Public Transport";
                texts["LowCity"] = "Special: Low city";
                texts["HardAndFast"] = "Special: Hard and fast";

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

                texts["POPULATION_TARGET_MULTIPLIER"] = "Population required to unlock milestones";
            }
        }
    }
}
