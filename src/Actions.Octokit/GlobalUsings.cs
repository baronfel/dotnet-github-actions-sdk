﻿// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

global using System.Text;
global using System.Text.Json;
global using System.Text.Json.Serialization;

global using Actions.Octokit.Interfaces;
global using Actions.Octokit.Serialization;

global using GitHub;
global using GitHub.Authentication;
global using GitHub.Client;

global using Microsoft.Extensions.DependencyInjection;

global using static System.Environment;
global using static Actions.Octokit.EnvironmentVariables.Keys;