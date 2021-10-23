import argparse
import datetime
import json
from typing import Any, Dict, List
import random
import string
import csv

statics = {} # hacky short term memory

def create_data(config: Dict[Any, Any]) -> None:
    for table in config.keys():
        if table == "counts":
            continue
        data = []
        n = config["counts"][table]
        for _ in range(n):
            data.append(create_dataset(config[table]))

        with open(f"{table}.csv", "w+") as out_csv:
            writer = csv.DictWriter(out_csv, fieldnames=data[0].keys())
            writer.writeheader()
            writer.writerows(data)

def create_dataset(config: Dict[Any, Any]) -> Dict[str, Any]:
    data_set = {}
    for attribute in config.keys():
        if config[attribute]["type"] == "Enumeration":
            if "enumeration" not in statics.keys():
                statics["enumeration"] = 0
            else:
                statics["enumeration"] += 1
            data_set[attribute] = statics["enumeration"]

        if config[attribute]["type"] == "RandomString":
            data_set[attribute] = "".join(random.choices(string.ascii_lowercase, k=config[attribute]["config"]["length"]))

        if config[attribute]["type"] == "Categories":
            categories = list(config[attribute]["config"].keys())
            weights = list(config[attribute]["config"].values())
            if sum(config[attribute]["config"].values()) < 1.0:
                categories.append("".join(random.choices(string.ascii_lowercase, k=3)))
                weights.append( 1.0 - sum(config[attribute]["config"].values()) )
            data_set[attribute] = random.choices(categories, weights=weights, k=1)[0]

        if config[attribute]["type"] == "IntegerRange":
            if "step" in config[attribute]["config"]:
                range_int = config[attribute]["config"]["end"] - config[attribute]["config"]["start"]
                data_set[attribute] = config[attribute]["config"]["start"] + random.randint(0, int(range_int / config[attribute]["config"]["step"])) * config[attribute]["config"]["step"]
            else:
                data_set[attribute] = random.randint(config[attribute]["config"]["start"], config[attribute]["config"]["end"])

        if config[attribute]["type"] == "FloatRange":
            data_set[attribute] = config[attribute]["config"]["start"] + random.random() * (config[attribute]["config"]["end"] - config[attribute]["config"]["start"])

        if config[attribute]["type"] == "DatetimeRange":
            start_date = datetime.datetime.fromisoformat(config[attribute]["config"]["start"])
            end_date = datetime.datetime.fromisoformat(config[attribute]["config"]["end"])
            data_set[attribute] = (start_date + random.random() * (end_date - start_date)).isoformat()

        if config[attribute]["type"] == "ForeignKey":
            with open(f"{config[attribute]['config']['target_file']}.csv", "r") as target_file:
                reader = csv.DictReader(target_file)
                read = list(reader)
                data_set[attribute] = random.choice(read)[config[attribute]["config"]["target_column"]]

    return data_set


if __name__ == "__main__":
    parser = argparse.ArgumentParser()
    args = parser.parse_args()
    with open("config.json", "r") as cfg:
        config = json.load(cfg)

    create_data(config)
