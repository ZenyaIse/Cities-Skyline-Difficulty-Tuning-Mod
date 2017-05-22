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
            if (selectedLanguage == "fr")
            {
                texts["MOD_NAME"] = "Difficulté Tuning Mod";
                texts["MOD_DESCRIPTION"] = "Variété de niveaux de difficulté.";

                texts["Easy"] = "1. Facile";
                texts["Normal"] = "2. Normal";
                texts["Advanced"] = "3. Avancée";
                texts["Hard"] = "4. Difficile";
                texts["Expert"] = "5. Expert";
                texts["Challenge"] = "6. Challenge";
                texts["Impossible"] = "7. Impossible";
                texts["Custom"] = "-- Personnalisées --";
                texts["Free"] = "Special: Gratuit";
                texts["FiveHundred"] = "Special: ¢500,000 Au Commencement";
                texts["Demand111"] = "Special: Demande 100%";
                texts["PublicTransport"] = "Special: Transport en Commun Gratuit";
                texts["LowCity"] = "Special: Ville Basse";
                texts["HardAndFast"] = "Special: Rapide et Difficile";

                texts["DIFFICULTY_LEVEL"] = "Niveau de Difficulté";
                texts["CUSTOM_OPTIONS"] = "Options Personnalisées";

                texts["SERVICE_BUILDINGS"] = "Les Bâtiments De Service";
                texts["PUBLIC_TRANSPORT"] = "Transport en commun ";
                texts["ROADS"] = "Route";
                texts["OTHERS"] = "Autre";

                texts["AREA_COST_MULTIPLIER"] = "Zone multiplicateur de coût";
                texts["INITIAL_MONEY"] = "Capital initial";
                texts["REWARD"] = "Montant De Récompense"; // Montant d'argent que vous obtenez lorsque une étape est franchie

                texts["POLLUTION_RADIUS"] = "Rayon de la Pollution";
                texts["GROUND_POLLUTION"] = "Pollution des Sols";
                texts["ONLY_POWER_WATER_GARBAGE"] = "*Installations d'Alimentation, d'Eau et Des Déchets Seulement";

                texts["DEMAND"] = "Demande";
                texts["DEMAND_FORMULA"] = "*Formule: (Demande + Offset) * Multiplicateur";
                texts["DEMAND_OFFSET"] = "Demande offset";
                texts["DEMAND_MULTIPLIER"] = "Demande multiplicateur";

                texts["TAGRET_LANDVALUE"] = "Cibler les valeurs Foncières pour les Bâtiments de monter de Niveau (Niveau 2, 3, 4, 5)";
                texts["RESIDENTIAL"] = "Residential";
                texts["COMMERCIAL"] = "Commercial";
                texts["TAGRET_SCORE"] = "Ciblez des notes de service pour les Bâtiments de monter de Niveau (Niveau 2, 3)";
                texts["INDUSTRIAL"] = "Industriel";
                texts["OFFICE"] = "Bureau";

                texts["POPULATION_TARGET_MULTIPLIER"] = "Population requis pour Déverrouiller Jalons";
                texts["MAX_SLOPE"] = "Maximum slope for roads, railroads and metro";
            }
            else if (selectedLanguage == "nl")
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

                texts["POLLUTION_RADIUS"] = "Vervuilingsstraal";
                texts["GROUND_POLLUTION"] = "Grondvervuiling";
                texts["ONLY_POWER_WATER_GARBAGE"] = "*Enkel elektriciteits-, water- en afvalfaciliteiten";

                texts["DEMAND"] = "Vraag";
                texts["DEMAND_FORMULA"] = "*Formule: (Vraag + Impuls) * vermenigvuldigingsfactor";
                texts["DEMAND_OFFSET"] = "Impuls";
                texts["DEMAND_MULTIPLIER"] = "Vermenigvuldigingsfactor";

                texts["TAGRET_LANDVALUE"] = "Grondrichtprijzen om op te waarderen (niveau 2, 3, 4, 5)";
                texts["RESIDENTIAL"] = "Woongebouwen";
                texts["COMMERCIAL"] = "Handelsgebouwen";
                texts["TAGRET_SCORE"] = "Dienstenscoredoel voor gebouwen om op te waarderen (niveau 2, 3)";
                texts["INDUSTRIAL"] = "Industriegebouwen";
                texts["OFFICE"] = "Kantoorgebouwen";

                texts["POPULATION_TARGET_MULTIPLIER"] = "Vereiste bevolking om mijlpalen te ontgrendelen";
                texts["MAX_SLOPE"] = "Maximale helling voor wegen, spoor en metro";
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
                texts["HardAndFast"] = "Speziell: Schwer und schnell";

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

                texts["POLLUTION_RADIUS"] = "Verschmutzungsradius";
                texts["GROUND_POLLUTION"] = "Bodenverschmutzung";
                texts["ONLY_POWER_WATER_GARBAGE"] = "*Nur Strom-, Wasser- und Abfallanlagen";

                texts["DEMAND"] = "Frage";
                texts["DEMAND_FORMULA"] = "*Formel: (Frage + Impuls) * Multiplikator";
                texts["DEMAND_OFFSET"] = "Impuls";
                texts["DEMAND_MULTIPLIER"] = "Multiplikator";

                texts["TAGRET_LANDVALUE"] = "Bodenrichtpreise für Gebaude zu verbesseren (Stufe 2, 3, 4, 5)";
                texts["RESIDENTIAL"] = "Wohngebäude";
                texts["COMMERCIAL"] = "Gewerbgebäude";
                texts["TAGRET_SCORE"] = "Dienstergebnisziel für Gebaude zu verbesseren (Stufe 2, 3)";
                texts["INDUSTRIAL"] = "Industriegebäude";
                texts["OFFICE"] = "Bürogebäude";

                texts["POPULATION_TARGET_MULTIPLIER"] = "Erforderliche Bevölkerung um Meilensteine zu entsperren";
                texts["MAX_SLOPE"] = "Maximale Gefälle für Straßen, Eisenbahnen und U-Bahnen";
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

                texts["POLLUTION_RADIUS"] = "Raggio di inquinamento";
                texts["GROUND_POLLUTION"] = "Inquinamento del suolo";
                texts["ONLY_POWER_WATER_GARBAGE"] = "*Solo strutture elettricità, acqua e spazzatura";

                texts["DEMAND"] = "Domanda";
                texts["DEMAND_FORMULA"] = "*Formula: (Domanda + Impulso) * Moltiplicatore";
                texts["DEMAND_OFFSET"] = "Impulso";
                texts["DEMAND_MULTIPLIER"] = "Moltiplicatore";

                texts["TAGRET_LANDVALUE"] = "Obiettivo valore del terreno per edifici a salire livello (Livello 2, 3, 4, 5)"; // To check
                texts["RESIDENTIAL"] = "Residenziale";
                texts["COMMERCIAL"] = "Commerciale";
                texts["TAGRET_SCORE"] = "Obiettivo punteggio di servizio per edifici a salire livello (Livello 2, 3)";
                texts["INDUSTRIAL"] = "Industriale";
                texts["OFFICE"] = "Uffici";

                texts["POPULATION_TARGET_MULTIPLIER"] = "Popolazione necessaria per sbloccare pietre miliari";
                texts["MAX_SLOPE"] = "Pendenza massima per strade, ferrovie e metropolitane";
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
                texts["Free"] = "Especial: Grátis";
                texts["FiveHundred"] = "Especial: ₡500.000 no início";
                texts["Demand111"] = "Especial: Demande em 100%";
                texts["PublicTransport"] = "Especial: Transporte Público Gratuito";
                texts["LowCity"] = "Especial: Cidade de baixo crescimento";
                texts["HardAndFast"] = "Especial: Difícil e rápido";

                texts["DIFFICULTY_LEVEL"] = "Nível de dificuldade";
                texts["CUSTOM_OPTIONS"] = "Opções personalizadas";

                texts["SERVICE_BUILDINGS"] = "Edifícios de serviços";
                texts["PUBLIC_TRANSPORT"] = "Transporte público";
                texts["ROADS"] = "Estradas";
                texts["OTHERS"] = "Outros";

                texts["AREA_COST_MULTIPLIER"] = "Multiplicador de custos da área";
                texts["INITIAL_MONEY"] = "Capital inicial";
                texts["REWARD"] = "Recompensa";

                texts["POLLUTION_RADIUS"] = "Raio Poluição";
                texts["GROUND_POLLUTION"] = "Poluição do Solo";
                texts["ONLY_POWER_WATER_GARBAGE"] = "*apenas de energia, instalações de água e de lixo";

                texts["DEMAND"] = "Demanda";
                texts["DEMAND_FORMULA"] = "*Fórmula: (Demanda + Compensação) * multiplicador";
                texts["DEMAND_OFFSET"] = "Compensação";
                texts["DEMAND_MULTIPLIER"] = "Multiplicador";

                texts["TAGRET_LANDVALUE"] = "Valores-alvo do custo da terra para edifícios a subir de nível (Nível 2, 3, 4, 5)";
                texts["RESIDENTIAL"] = "Residenciais";
                texts["COMMERCIAL"] = "Comerciais";
                texts["TAGRET_SCORE"] = "Valores-alvo da pontuação serviço para edifícios a subir de nível (Nível 2, 3)";
                texts["INDUSTRIAL"] = "Industriais";
                texts["OFFICE"] = "Escritórios";

                texts["POPULATION_TARGET_MULTIPLIER"] = "A população necessária para desbloquear marcos";
                texts["MAX_SLOPE"] = "Maximum slope for roads, railroads and metro";
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

                texts["POLLUTION_RADIUS"] = "Радиус загрязнений";
                texts["GROUND_POLLUTION"] = "Загрязнения почвы";
                texts["ONLY_POWER_WATER_GARBAGE"] = "*Только для электро, водных и мусорных предприятий";

                texts["DEMAND"] = "Потребность";
                texts["DEMAND_FORMULA"] = "*Формула: (Потребность + Смещение) * Коэффициент";
                texts["DEMAND_OFFSET"] = "Смещение";
                texts["DEMAND_MULTIPLIER"] = "Коэффициент";

                texts["TAGRET_LANDVALUE"] = "Цена земли, необходимая для повышения уровня зданий (уровень 2, 3, 4, 5)";
                texts["RESIDENTIAL"] = "Жилых";
                texts["COMMERCIAL"] = "Коммерческих";
                texts["TAGRET_SCORE"] = "Сервис, необходимый для повышения уровня зданий (уровень 2, 3)";
                texts["INDUSTRIAL"] = "Промышленных";
                texts["OFFICE"] = "Офисных";

                texts["POPULATION_TARGET_MULTIPLIER"] = "Числ. населения для достижения этапов";
                texts["MAX_SLOPE"] = "Максимальный уклон авто-, жел. дорог и метро";
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

                texts["POLLUTION_RADIUS"] = "汚染半径";
                texts["GROUND_POLLUTION"] = "土壌汚染";
                texts["ONLY_POWER_WATER_GARBAGE"] = "※電力、上下水道、ゴミ施設のみ";

                texts["DEMAND"] = "需要";
                texts["DEMAND_FORMULA"] = "※式：　（需要＋オフセット）＊係数";
                texts["DEMAND_OFFSET"] = "オフセット";
                texts["DEMAND_MULTIPLIER"] = "係数";

                texts["TAGRET_LANDVALUE"] = "建物レベルアップのための地価の目標値（レベル2,3,4,5）";
                texts["RESIDENTIAL"] = "住宅";
                texts["COMMERCIAL"] = "商業";
                texts["TAGRET_SCORE"] = "建物レベルアップのためのサービススコアの目標値（レベル2,3）";
                texts["INDUSTRIAL"] = "産業";
                texts["OFFICE"] = "オフィス";

                texts["POPULATION_TARGET_MULTIPLIER"] = "マイルストーンの目標人口の係数";
                texts["MAX_SLOPE"] = "道路、鉄道、地下鉄の線路の最大勾配";
            }
            else if (selectedLanguage == "ko")
            {
                texts["MOD_NAME"] = "난이도 조절 모드";
                texts["MOD_DESCRIPTION"] = "다양한 난이도를 제공합니다.";

                texts["Easy"] = "1. 쉬움";
                texts["Normal"] = "2. 보통";
                texts["Advanced"] = "3. 권장";
                texts["Hard"] = "4. 어려움";
                texts["Expert"] = "5. 전문가";
                texts["Challenge"] = "6. 도전";
                texts["Impossible"] = "7. 불가능";
                texts["Custom"] = "-- 커스텀 --";
                texts["Free"] = "특별 난이도 : 모두 무료";
                texts["FiveHundred"] = "특별 난이도 : 시작 금액 ₡500,000";
                texts["Demand111"] = "특별 난이도 : 수요 100%";
                texts["PublicTransport"] = "특별 난이도: 대중교통 유지비용 무료;
                texts["LowCity"] = "특별 난이도 : 낮은건물 도시";
                texts["HardAndFast"] = "특별 난이도 : 어렵고 빠름";

                texts["DIFFICULTY_LEVEL"] = "난이도 선택";
                texts["CUSTOM_OPTIONS"] = "커스텀 옵션";

                texts["SERVICE_BUILDINGS"] = "서비스 건물";
                texts["PUBLIC_TRANSPORT"] = "공공 건물;
                texts["ROADS"] = "도로";
                texts["OTHERS"] = "기타";

                texts["AREA_COST_MULTIPLIER"] = "맵 확상 비용";
                texts["INITIAL_MONEY"] = "시작 금액";
                texts["REWARD"] = "단계 보상 금액";

                texts["POLLUTION_RADIUS"] = "오염 수치";
                texts["GROUND_POLLUTION"] = "토양 오염";
                texts["ONLY_POWER_WATER_GARBAGE"] = "※ 전기, 물, 쓰레기 시설만 해당";

                texts["DEMAND"] = "수요";
                texts["DEMAND_FORMULA"] = "공식 : (수요 + 성장여부) * 성장속도";
                texts["DEMAND_OFFSET"] = "성장 여부";
                texts["DEMAND_MULTIPLIER"] = "성장 속도";

                texts["TAGRET_LANDVALUE"] = "건물 성장에 필요한 값(레벨 2, 3, 4)";
                texts["RESIDENTIAL"] = "주거";
                texts["COMMERCIAL"] = "상업";
                texts["TAGRET_SCORE"] = "산업 성장에 필요한 값(레벨 2, 3)";
                texts["INDUSTRIAL"] = "산업";
                texts["OFFICE"] = "오피스";

                texts["POPULATION_TARGET_MULTIPLIER"] = "단계 보상 인구 수 비율";
                texts["MAX_SLOPE"] = "도로 및 철로 최대 경사도";
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

                texts["POLLUTION_RADIUS"] = "Pollution radius";
                texts["GROUND_POLLUTION"] = "Ground pollution";
                texts["ONLY_POWER_WATER_GARBAGE"] = "*Power, water, and garbage facilities only";

                texts["DEMAND"] = "Demand";
                texts["DEMAND_FORMULA"] = "*Formula: (Demand + Offset) * multiplier";
                texts["DEMAND_OFFSET"] = "Demand offset";
                texts["DEMAND_MULTIPLIER"] = "Demand multiplier";

                texts["TAGRET_LANDVALUE"] = "Target land values for buildings to level up (Level 2, 3, 4, 5)";
                texts["RESIDENTIAL"] = "Residential";
                texts["COMMERCIAL"] = "Commercial";
                texts["TAGRET_SCORE"] = "Target service score for buildings to level up (Level 2, 3)";
                texts["INDUSTRIAL"] = "Industrial";
                texts["OFFICE"] = "Office";

                texts["POPULATION_TARGET_MULTIPLIER"] = "Population required to unlock milestones";
                texts["MAX_SLOPE"] = "Maximum slope for roads, railroads and metro";
            }
        }
    }
}
