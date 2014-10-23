
# Don't forget to change the path below to your copy of Octopus.Client.dll
Add-Type -Path "C:\Program Files (x86)\Go Agent\pipelines\Wedding\dotnnet\Wedding\packages\Octopus.Client.2.5.11.610\lib\net40\ReleaseOctopus.Client.dll"



 
 
$endpoint = new-object Octopus.Client.OctopusServerEndpoint "https://goserver","API-RORM5DBGZMOSYGE7OSE5EZPQA"
$repository = new-object Octopus.Client.OctopusRepository $endpoint
 
$envId = $repository.Environments.FindByName("Production")
$machines = $repository.Environments.GetMachines($envId)
 
$machines | Format-Table


