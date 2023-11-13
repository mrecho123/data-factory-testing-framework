class VariableDoesNotExistError(Exception):
    def __init__(self, variable_name) -> None:
        super().__init__(f"Variable does not exist: {variable_name}")
