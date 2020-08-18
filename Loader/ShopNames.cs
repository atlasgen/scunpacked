using System;
using System.Collections.Generic;

namespace Loader
{
	public static class ShopNames
	{
		public static Dictionary<string, string> Lookup = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
		{
			{ "AdminOffice_Area18", "Area 18 IO North Tower" },
			{ "AdminOffice_Grimhex", "Grim Hex Admin Office" },
			{ "AdminOffice_Levski", "Levski"},
			{ "AdminOffice_Lorville", "Lorville (In L19 Admin Office)" },
			{ "AdminOffice_NewBabbage", "New Babbage MT Planetary Services" },
			{ "AdminOffice_PortO", "Port Olisar" },
			{ "AdminOffice_Stanton1_L1", "HUR L1" },
			{ "AdminOffice_Stanton1_L2", "HUR L2" },
			{ "AdminOffice_Stanton1_L3", "HUR L3" },
			{ "AdminOffice_Stanton1_L4", "HUR L4" },
			{ "AdminOffice_Stanton1_L5", "HUR L5" },
			{ "AdminOffice_Stanton1_LEO1", "Everus Harbor" },
			{ "AdminOffice_Stanton2_L1", "CRU L1" },
			{ "AdminOffice_Stanton2_L4", "Shallow Fields Station (removed)" },
			{ "AdminOffice_Stanton2_L5", "CRU L5 Admin Office" },
			{ "AdminOffice_Stanton3_L1", "ARC L1" },
			{ "AdminOffice_Stanton3_LEO1", "Baijini Point" },
			{ "AdminOffice_Stanton4_L1", "R & R MIC-L1" },
			{ "AdminOffice_Stanton4_LEO1", "Port Tressler" },
			{ "arccorp_cluster_001_frost", "Arc Corp Mining Area 157" },
			{ "arccorp_cluster_001_sand", "Arc Corp Mining Area 141" },
			{ "drug_farm_001_frost", "Jumptown" },
			{ "DrugLab_Stanton3a_ParadiseCove", "Paradise Cove" },
			{ "Fence_Junkyard_Stanton1_1", "Fence Junkyard" },
			{ "Fence_Junkyard_Stanton2b_1", "Brio’s Breaker Yard" },
			{ "Fence_Junkyard_Stanton3b_1", "Samson & Son’s Salvage Center" },
			{ "Fence_RestStop2_4", "Reclamation & Disposal Orinth (Junkyard)" },
			{ "Fence_RestStop2_5", "CRU L5 Locker Room" },
			{ "indy_farmer_001_dust", "Gallete Family Farms" },
			{ "indy_farmer_001_sand", "Bountiful Harvest Hydroponics" },
			{ "indy_miner_001_dust", "Tram & Meyers Mining" },
			{ "indy_miner_001_frost", "Benson Mining Outpost" },
			{ "indy_miner_001_sand", "Kudre Ore" },
			{ "Klescher_Aberdeen", "Klescher Prison Commissary" },
			{ "MiningKiosks_Area18", "Area Refining Terminal" },
			{ "MiningKiosks_GrimHex", "Grim Hex Refining Terminal" },
			{ "rayari_cluster_001_dust", "Hickes Research Outpost" },
			{ "rayari_cluster_001_frost", "Deakins Research Outpost" },
			{ "shubin_cluster_001_sand", "Shubin Mining Facility SCD-1" },
			{ "stanton_1_hrst_001", "HDMS Edmond" },
			{ "stanton_1_hrst_002", "HDMS Oparei" },
			{ "stanton_1_hrst_003", "HDMS Pinewood" },
			{ "stanton_1_hrst_004", "HDMS Thedus" },
			{ "stanton_1_hrst_005", "HDMS Hadley" },
			{ "stanton_1_hrst_006", "HDMS Stanhope" },
			{ "stanton_1a_hrst_001", "HDMS Bezdek" },
			{ "stanton_1a_hrst_002", "HDMS Lathan" },
			{ "stanton_1b_hrst_001", "HDMS Norgaard" },
			{ "stanton_1b_hrst_002", "HDMS Anderson" },
			{ "stanton_1c_hrst_001", "HDMS Hahn" },
			{ "stanton_1c_hrst_002", "HMDS Perlman" },
			{ "stanton_1d_hrst_001", "HDMS Woodruff" },
			{ "stanton_1d_hrst_002", "HDMS Ryder" },
			{ "stanton_3a_indy_humboldt", "Humbolt Mines" },
			{ "stanton_3a_indy_loveridge", "Loveridge Mineral Reserve" },
			{ "stanton_3a_shubin_sal2", "Shubin Mining Facility (SAL 2)" },
			{ "stanton_3a_shubin_sal5", "Shubin Mining Facility (SAL 5)" },
			{ "stanton_3b_arccorp_area045", "Arc Corp mining Area 45" },
			{ "stanton_3b_arccorp_area048", "Arc Corp mining Area 48" },
			{ "stanton_3b_arccorp_area056", "Arc Corp mining Area 56" },
			{ "stanton_3b_arccorp_area061", "Arc Corp mining Area 61" },
			{ "stanton_3b_indyFarm_001", "Shady Glen Farms" },
			{ "stanton_4_rayari_001", "Rayari Deltana Research Outpost" },
			{ "stanton_4a_drugfarm_001", "Raven's Roost" },
			{ "stanton_4a_rayari_001", "Rayari Anvik Research Outpost" },
			{ "stanton_4a_rayari_002", "Rayari Kaltag Research Outpost" },
			{ "stanton_4a_shubin_001", "Shubin Mining Facility SMCa-6" },
			{ "stanton_4a_shubin_002", "Shubin Mining Facility SMCa-8" },
			{ "stanton_4b_rayari_001", "Rayari Cantwell Research Outpost" },
			{ "stanton_4b_rayari_002", "Rayari McGrath Research Outpost" },
			{ "stanton_4c_indyFarm_001", "Bud's Growery" },
			{ "StashHouse_Stanton2a_PrivateProperty", "Private Property" },
			{ "StashHouse_Stanton2b_NuenWaste", "Nuen Waste Management" },
			{ "StashHouse_Stanton2c_NT999XX", "NT-999-XX (Stash house)" },
			{ "StashHouse_Stanton3a_Orphanage", "The Orphanage" },
			{ "StashHouse_Stanton4", "Cellin Stash House" },
			{ "t_mills_cluster_001_dust", "Terra Mills Hydro Farm" },
			{ "TDD_Area18", "Area 18 TDD Building" },
			{ "TDD_NewBabbage", "New Babbage TDD" },
			{ "Transfers_Lorville", "Lorville CBD (In Transfers Room)" },
			{ "Fence_Junkyard_Stanton4c_1", "Devlin Scrap & Salvage" }
		};
	}
}