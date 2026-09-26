# Automated Asset Detection Prototype

A legacy prototype that explores asset inventory through image-based object detection and a web interface for reviewing captured and missing items.

The project combines a Python detection process with an ASP.NET Web Forms application and a MySQL database. It was built as an academic prototype and is preserved here as a record of the design and implementation.

## How it works

1. A Python worker reads an input image.
2. ImageAI and RetinaNet identify objects in the image.
3. Detected object names are stored in MySQL.
4. The web application compares captured objects with the expected inventory.
5. Missing items are shown through the browser interface.

## Repository structure

```text
Python.py       Image detection and database worker
frontend/DIP/   ASP.NET Web Forms interface
```

The web project also contains older hotel-management pages that were reused as part of the prototype interface. They should be separated or removed in a future revision.

## Technology

- Python
- ImageAI and RetinaNet
- TensorFlow
- MySQL
- ASP.NET Web Forms
- C#

## Local database configuration

The Python worker reads its MySQL settings from these environment variables:

```text
ASSET_DB_HOST
ASSET_DB_USER
ASSET_DB_PASSWORD
ASSET_DB_NAME
```

The C# MySQL connector reads a complete connection string from `ASSET_MANAGEMENT_DB_CONNECTION_STRING`.

For the legacy SQL Server pages, copy `frontend/DIP/ConnectionStrings.example.config` to `frontend/DIP/ConnectionStrings.config` and replace the placeholder values locally. The local file is ignored by Git.

## Project status

This code is not production ready. It targets an older software stack and currently requires cleanup before it can be run safely.

Important work still needed:

- Rotate the previously exposed database credentials and purge them from Git history
- Validate the environment-variable and local configuration workflow
- Replace the incomplete Python worker with a reproducible command-line entry point
- Add the database schema and seed data
- Separate the asset-detection interface from unrelated hotel pages
- Upgrade the object-detection dependencies
- Add tests and input validation

## What I learned

- How an object-detection model can feed an inventory workflow
- How to connect a Python processing task with a database-backed web interface
- How model output must be normalized before it becomes useful application data
- Why configuration and secrets must be separated from source code

## Responsible use

Object detection is probabilistic. A real asset-management system should preserve confidence scores, support human review, and avoid treating model output as authoritative without validation.

## License

This repository is available under the MIT License. See `LICENSE.md` for details.

