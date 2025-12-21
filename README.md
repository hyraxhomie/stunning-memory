# stunning-memory

| Project | Purpose | References |
|---------|---------|------------|
| `Domain` | Your entities (OT, PD, DT), interfaces, core logic | Nothing - it's the innermost layer |
| `Infrastructure` | EF Core DbContext, migrations, repositories, SQL generation | Domain |
| `Api` | Controllers/endpoints, DI setup, app configuration | Infrastructure (and transitively Domain) |
