The goal of this website is to give helpful tools while explaing some of the more complex topics in the game in a way that people understand. The main issue that I have found with the game as it stands is that many things do not work as they are stated and are bugged so explaining how they are bugged and why will hopefully help new players. The other reson that I want to make this website is because It would be fun to make.


| Week | Concept | Feature | Goal | Acceptance Criteria | Evidence in README.md | Test Plan |
|------|----------|----------|------|----------------------|------------------------|------------|
| 10 | Modeling | Create a player and styles entities | App can store styles and assign them to the player | - Player table created <br> - Styles table created <br> - Relationship works | Implemented code; README write-up; screenshots as needed | Run migration; check DB tables exist |
| 11 | Separation of Concerns / DI | Add `IStatMult` to calculate how stat affects damage | Move logic out of controller into a service | - Service registered in DI <br> - Controller uses constructor injection <br> - Damage multiplier returned correctly | Implemented code; README write-up; screenshots as needed | Call endpoint; verify ripe/rotten labels |
| 12 | CRUD | Add Create/Edit forms for Styles | Users can add or edit Styles | - Form displays <br> - Validation messages show <br> - Changes save to DB | Implemented code; README write-up; screenshots as needed | Add new style, edit it, confirm DB update |
| 13 | Diagnostics | Add `/healthz` endpoint | App reports if Styles DB is reachable | - Healthy when DB up <br> - Unhealthy when DB down | Implemented code; README write-up; screenshots as needed | Stop DB and hit `/healthz` |
| 14 | Logging | Log every style added to make sure it’s correct | Record structured logs when people add styles | - Log message created <br> - Contains Style ID | Implemented code; README write-up; screenshots as needed | Add Style; check log output |
| 15 | Stored Procedures | Call SP: Styles with lowest stat total | Show leaderboard of styles with the most freedom | - SP executes <br> - Results displayed | Implemented code; README write-up; screenshots as needed | Run SP in app and DB; compare results |
| 16 | Deployment | Deploy app to Azure App Service | Make the application accessible in the cloud with production settings | - App Service created <br> - App builds and runs on Azure <br> - `/healthz` reachable <br> - One functional path works | Implemented code; README write-up; deployed URL; screenshots | Visit public URL; confirm health endpoint and one page load |






10	Modeling			Both the player and style models have been made	The App can store styles and assigen them to the player			-player table created -styles table created -Relationship works						using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

The models for now only make 3 classes that refernce eachother and have most of what will be needed in the future to make that information be useful with the calculations that will be added next week and some backbone for future ui developments



	Run migration; check DB tables exist Yup they exist
