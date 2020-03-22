//////////////////////////////////
// this enum is not documented yet
//////////////////////////////////
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1602 // Enumeration items should be documented

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// strategic number.
    /// </summary>
    public enum sn
    {
        // CIVILIAN NUMBERS
        percent_civilian_explorers,
        percent_civilian_builders,
        percent_civilian_gatherers,
        cap_civilian_explorers,
        cap_civilian_builders,
        cap_civilian_gatherers,
        total_number_explorers,
        minimum_civilian_explorers,
        food_gatherer_percentage,
        gold_gatherer_percentage,
        stone_gatherer_percentage,
        wood_gatherer_percentage,
        number_enemy_objects_required,
        retask_gather_amount,
        max_retask_gather_amount,
        initial_exploration_required,
        use_by_type_max_gathering,
        percent_half_exploration,
        minimum_boar_hunt_group_size,
        number_forward_builders,

        // GROUP-RELATED NUMBERS
        group_commander_selection_method,
        consecutive_idle_unit_limit,
        task_ungrouped_soldiers,

        // ATTACK GROUP NUMBERS
        number_attack_groups,
        minimum_attack_group_size,
        maximum_attack_group_size,
        group_form_distance,
        scale_minimum_attack_group_size,
        scale_maximum_attack_group_size,
        attack_group_size_randomness,
        attack_group_gather_spacing,
        group_leader_defense_distance,
        percent_attack_soldiers,
        percent_attack_boats,

        // MISCELLANEOUS ATTACK NUMBERS
        percent_enemy_sighted_response,
        enemy_sighted_response_distance,
        blot_exploration_map,
        blot_size,
        maximum_gaia_attack_response,
        attack_separation_time_randomness,
        attack_intelligence,
        initial_attack_delay,
        initial_attack_delay_type,
        garrison_rams,

        // DEFEND GROUP NUMBERS
        number_defend_groups,
        minimum_defend_group_size,
        maximum_defend_group_size,
        gold_defend_priority,
        stone_defend_priority,
        forage_defend_priority,
        relic_defend_priority,
        town_defend_priority,
        defense_distance,
        sentry_distance,
        sentry_distance_variation,
        defend_overlap_distance,
        gather_idle_soldiers_at_center,

        // EXPLORE GROUP NUMBERS
        number_explore_groups,
        minimum_explore_group_size,
        maximum_explore_group_size,

        // BOAT ATTACK GROUP NUMBERS
        number_boat_attack_groups,
        minimum_boat_attack_group_size,
        maximum_boat_attack_group_size,

        // BOAT DEFEND GROUP NUMBERS
        number_boat_defend_groups,
        minimum_boat_defend_group_size,
        maximum_boat_defend_group_size,
        dock_defend_priority,

        // BOAT EXPLORE GROUP NUMBERS
        number_boat_explore_groups,
        minimum_boat_explore_group_size,
        maximum_boat_explore_group_size,

        // TOWN BUILDING NUMBERS
        minimum_town_size,
        maximum_town_size,
        camp_max_distance,
        mill_max_distance,
        minimum_water_body_size_for_dock,
        max_build_plan_gatherer_percentage,
        food_dropsite_distance,
        wood_dropsite_distance,
        stone_dropsite_distance,
        gold_dropsite_distance,
        minimum_dropsite_buffer,
        random_placement_factor,
        required_forest_tiles,

        // TARGET EVALUATION NUMBERS
        target_evaluation_distance,
        target_evaluation_hitpoints,
        target_evaluation_damage_capability,
        target_evaluation_kills,
        target_evaluation_ally_proximity,
        target_evaluation_rof,
        target_evaluation_randomness,
        target_evaluation_attack_attempts,
        target_evaluation_range,
        special_attack_type1,
        special_attack_influence1,
        target_evaluation_continent,
        target_evaluation_siege_weapon,
        target_evaluation_boat,
        target_evaluation_time_kill_ratio,
        target_evaluation_in_progress,

        // MISCELLANEOUS NUMBERS
        do_not_scale_for_difficulty_level,
        relic_return_distance,
        minimum_peace_like_level,
        percent_exploration_required,
        zero_priority_distance,
        scaling_frequency,
        build_frequency,
        save_scenario_information,
        number_build_attempts_before_skip,
        max_skips_per_attempt,
        minimum_amount_for_trading,
        hits_before_alliance_change,
        attack_diplomacy_impact,
        easiest_reaction_percentage,
        easier_reaction_percentage,
        track_player_history,
        attack_winning_player,
        coop_share_information,
        attack_winning_player_factor,
        coop_share_attacking,
        coop_share_attacking_interval,
        percentage_explore_exterminators,
        maximum_wood_drop_distance,
        maximum_food_drop_distance,
        maximum_hunt_drop_distance,
        maximum_fish_boat_drop_distance,
        maximum_gold_drop_distance,
        maximum_stone_drop_distance,

        // Undocumented
        gather_defense_units,

#if USER_PATCH
        minimum_number_hunters,
        minimum_boar_lure_group_size,
        enable_boar_hunting,
#endif // USER_PATCH
    }
}
#pragma warning restore SA1602 // Enumeration items should be documented
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
