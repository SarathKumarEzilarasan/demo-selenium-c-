package _Self.buildTypes

import jetbrains.buildServer.configs.kotlin.*
import jetbrains.buildServer.configs.kotlin.buildFeatures.perfmon
import jetbrains.buildServer.configs.kotlin.buildSteps.script
import jetbrains.buildServer.configs.kotlin.triggers.vcs

object Build : BuildType({
    name = "Build"

    artifactRules = "SpecFlowBDDAutomationFramework-main/TestResults/*"

    vcs {
        root(HttpsGithubComSarathKumarEzilarasanDemoSeleniumCGitRefsHeadsMain)
    }

    steps {
        script {
            name = "Run Test"
            id = "Run_Test"
            scriptContent = """
                cd SpecFlowBDDAutomationFramework-main
                dotnet test
            """.trimIndent()
        }
    }

    triggers {
        vcs {
        }
    }

    features {
        perfmon {
        }
    }
})

