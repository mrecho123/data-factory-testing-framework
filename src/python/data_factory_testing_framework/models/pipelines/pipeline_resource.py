from typing import List

from data_factory_testing_framework.exceptions.activity_not_found_error import ActivityNotFoundError
from data_factory_testing_framework.generated.models import Activity, PipelineResource
from data_factory_testing_framework.models.base.run_parameter import RunParameter
from data_factory_testing_framework.models.base.run_parameter_type import RunParameterType


class PipelineResource:
    def get_activity_by_name(self: PipelineResource, name: str) -> Activity:
        for activity in self.activities:
            if activity.name == name:
                return activity

        raise ActivityNotFoundError(f"Activity with name {name} not found")

    def validate_parameters(self: PipelineResource, parameters: List[RunParameter]) -> None:
        # Check if all parameters are provided
        for pipeline_parameter_name, pipeline_parameter_specification in self.parameters.items():
            found = False
            for parameter in parameters:
                if pipeline_parameter_name == parameter.name and parameter.type == RunParameterType.Pipeline:
                    found = True
                    break

            if not found:
                raise ValueError(
                    f"Parameter with name '{pipeline_parameter_name}' and type '{pipeline_parameter_specification.type}' not found in pipeline '{self.name}'",
                )

        # Check if no duplicate parameters are provided
        for parameter in parameters:
            if sum(1 for p in parameters if p.name == parameter.name and p.type == parameter.type) > 1:
                raise ValueError(
                    f"Duplicate parameter with name '{parameter.name}' and type '{parameter.type}' found in pipeline '{self.name}'",
                )