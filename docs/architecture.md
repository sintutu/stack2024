# Architecture

I want a [front-end](./front-end.md), [api](./api.md) and [database](./erd.md). 

At this time I don't know what I want to show on the front end so I'm going to start from the data model and work upwards.

```mermaid
sequenceDiagram
    participant FrontEnd as Front End
    participant API as API
    participant Database as Database

    FrontEnd->>API: Request for /overview data
    API->>Database: Retrieve requirements, scenarios, and cases
    Database-->>API: Return data
    API-->>FrontEnd: Send data to Front End

    FrontEnd->>API: Request to save data
    API->>Database: Save new or updated data
    Database-->>API: Data saved
    API-->>FrontEnd: Confirmation of data saved
```