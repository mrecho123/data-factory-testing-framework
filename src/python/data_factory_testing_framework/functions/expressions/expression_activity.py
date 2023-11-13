import re

from data_factory_testing_framework.exceptions.activity_not_found_error import ActivityNotFoundError
from data_factory_testing_framework.models.state.pipeline_run_state import PipelineRunState


def find_and_replace_activity(expression: str, state: PipelineRunState):
    pattern = r"activity\('(?P<activity_name>.*?)'\)(?:\.(\w+))+$"
    match = re.match(pattern, expression)
    if match:
        activity_name = match.group("activity_name")
        fields = match.group(0).split(".")[1:]

        activity = state.try_get_scoped_activity_result_by_name(activity_name)
        if activity is None:
            raise ActivityNotFoundError(activity_name)

        field_value = activity
        for field in fields:
            field_value = field_value[field]

        expression = expression.replace(match.group(0), str(field_value))

    return expression
